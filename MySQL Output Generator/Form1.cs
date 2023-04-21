using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_Output_Generator
{
    public partial class Form1 : Form
    {
        Color RED = Color.FromArgb(255, 45, 85);
        Color GREEN = Color.FromArgb(25, 128, 40);
        Color BLUE = Color.FromArgb(12, 140, 233);

        MySqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
            PopulateFolders();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HighlightSyntax()
        {
            string keywords = @"\b(SHOW|USE|DATABASES|TABLES|SELECT|FROM|WHERE|GROUP BY|ORDER BY|JOIN|LEFT JOIN|RIGHT JOIN|FULL JOIN|INNER JOIN|OUTER JOIN|ON|AS|DISTINCT|HAVING|UNION|VALUES|INSERT INTO|UPDATE|DELETE FROM|CREATE TABLE|DROP TABLE|PRIMARY KEY|FOREIGN KEY|REFERENCES|NULL|NOT|AND|OR)\b";
            string comments = @"--.*$|/\*.*?\*/";
            string strings = @"'(\\'|[^'])*'";

            Regex keywordsRegex = new Regex(keywords, RegexOptions.IgnoreCase);
            Regex commentsRegex = new Regex(comments, RegexOptions.Multiline);
            Regex stringsRegex = new Regex(strings);

            int originalSelectionStart = codeTextBox.SelectionStart;
            int originalSelectionLength = codeTextBox.SelectionLength;

            foreach (Match match in keywordsRegex.Matches(codeTextBox.Text))
            {
                codeTextBox.Select(match.Index, match.Length);
                codeTextBox.SelectionColor = Color.Blue;
            }

            foreach (Match match in commentsRegex.Matches(codeTextBox.Text))
            {
                codeTextBox.Select(match.Index, match.Length);
                codeTextBox.SelectionColor = Color.Green;
            }

            foreach (Match match in stringsRegex.Matches(codeTextBox.Text))
            {
                codeTextBox.Select(match.Index, match.Length);
                codeTextBox.SelectionColor = Color.Red;
            }

            codeTextBox.Select(originalSelectionStart, originalSelectionLength);
            codeTextBox.SelectionColor = Color.Black;
            codeTextBox.SelectionStart = originalSelectionStart;
            codeTextBox.ScrollToCaret();
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightSyntax();
        }

        private void codeTextBox_SelectionChanged(object sender, EventArgs e)
        {
            //int currentLine = codeTextBox.GetLineFromCharIndex(codeTextBox.SelectionStart);
            //int start = codeTextBox.GetFirstCharIndexFromLine(currentLine);
            //int end = codeTextBox.GetFirstCharIndexFromLine(currentLine + 1);
            //if (end < 0)
            //{
            //    end = codeTextBox.TextLength;
            //}
            //int length = end - start;
            //codeTextBox.SelectionStart = start;
            //codeTextBox.SelectionLength = length;
            //codeTextBox.SelectionBackColor = Color.LightGray;

            //// Reset the selection color and position
            //codeTextBox.SelectionStart = codeTextBox.SelectionStart;
            //codeTextBox.SelectionLength = 0;
            //codeTextBox.SelectionBackColor = Color.White;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open) return;
            try
            {
                string connectionString = $"server={txtServer.Text};user id={txtRoot.Text};password={txtPassword.Text};";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                lblConnectionStatus.Text = "Connected";
                lblConnectionStatus.ForeColor = GREEN;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConnectionStatus.Text = "Not Connected";
                lblConnectionStatus.ForeColor = RED;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void ExecuteQuery(string query)
        {
            
            void invokeOnOutput(Action action) => lstOutput.Invoke(action);

            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    invokeOnOutput(new Action(() => lstOutput.Items.Clear()));

                    invokeOnOutput(new Action(() => lstOutput.Columns.Clear()));
                    invokeOnOutput(new Action(() => lstOutput.Items.Clear()));

                    foreach (DataColumn col in dt.Columns)
                    {
                        invokeOnOutput(new Action(() => lstOutput.Columns.Add(col.ColumnName)));
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }

                        invokeOnOutput(new Action(() => lstOutput.Items.Add(item)));
                    }
                }
            }
            
        }

        private async void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            if (conn == null || conn.State != ConnectionState.Open)
            {
                MessageBox.Show("MySQL not connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
            var start = DateTime.Now;
            var isError = true;

            try
            {
                string query = codeTextBox.Text;
                lblQueryStatus.Text = "Executing...";
                lblQueryStatus.ForeColor = BLUE;
                await Task.Run(() => ExecuteQuery(query)).ContinueWith((t) =>
                {
                    if (t.IsFaulted) throw t.Exception;
                });
                isError = false;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var end = DateTime.Now;
            var diff = end.Subtract(start).TotalMilliseconds;

            var status = isError ? "ERROR" : "OK";

            lblQueryStatus.Text = $"{status} | {(int)diff} ms";
            lblQueryStatus.ForeColor = isError ? RED : GREEN;
        }

        private void codeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnExecuteQuery_Click(sender, e);
                e.Handled = true;
            }
        }

        private void PopulateFolders()
        {
            cboOutputFolder.Items.Clear();
            foreach(var folder in Properties.Settings.Default.OUTPUT_FOLDERS)
            {
                cboOutputFolder.Items.Add(new DirectoryInfo(folder).Name);
            }

            if (cboOutputFolder.Items.Count > 0) cboOutputFolder.SelectedIndex = 0;
        }

        private void lnkCreateOutputFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                var folder = fbd.SelectedPath;
                Properties.Settings.Default.OUTPUT_FOLDERS.Add(folder);
                Properties.Settings.Default.Save();

                PopulateFolders();
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            if (cboOutputFolder.SelectedIndex >= 0)
                Process.Start(Properties.Settings.Default.OUTPUT_FOLDERS[cboOutputFolder.SelectedIndex].ToString());
        }
        private void ListViewToAsciiTableImage(ListView listView, string outputPath, string outputLabel)
        {
            int rowHeight = 30;
            int tableWidth = 0;
            int[] columnWidths = new int[listView.Columns.Count+1];

            foreach(ColumnHeader col in listView.Columns)
            {
                int width = TextRenderer.MeasureText(col.Text, listView.Font).Width;
                columnWidths[col.Index] = width;
            }

            foreach (ListViewItem item in listView.Items)
            {
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    int width = TextRenderer.MeasureText(item.SubItems[i].Text, listView.Font).Width;
                    columnWidths[i] = Math.Max(columnWidths[i], width);
                }
            }

            for (int i = 0; i < listView.Columns.Count; i++)
            {
                tableWidth += columnWidths[i] + 20;
            }

            var labelWidth = TextRenderer.MeasureText($"fig. {outputLabel}", listView.Font).Width;
            columnWidths[columnWidths.Length - 1] = labelWidth;
            tableWidth += labelWidth + 20;

            int tableHeight = Math.Min(400, (listView.Items.Count + 2) * rowHeight);

            using (Bitmap bmp = new Bitmap(tableWidth, tableHeight))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Font font = new Font("Consolas", 12);
                    SolidBrush brush = new SolidBrush(Color.White);

                    g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, tableWidth, tableHeight));

                    int x = 10;
                    int y = 10;
                    foreach (ColumnHeader column in listView.Columns)
                    {
                        g.DrawString(column.Text, font, brush, new PointF(x, y));
                        x += columnWidths[column.Index] + 20;
                    }
                    y += rowHeight;

                    Pen pen = new Pen(Color.White);
                    g.DrawLine(pen, new Point(10, y), new Point(tableWidth - 10, y));
                    y += 10;

                    foreach (ListViewItem item in listView.Items)
                    {
                        x = 10;
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            g.DrawString(subItem.Text, font, brush, new RectangleF(x, y, columnWidths[item.SubItems.IndexOf(subItem)], rowHeight), new StringFormat() { Trimming = StringTrimming.EllipsisCharacter });
                            x += columnWidths[item.SubItems.IndexOf(subItem)] + 20;
                        }
                        y += rowHeight;
                    }
                    if(!string.IsNullOrEmpty(outputLabel))
                    {
                        x = 10;
                        y += rowHeight;
                        g.DrawString($"fig. {outputLabel}", font, brush, new RectangleF(x, y, columnWidths[columnWidths.Length - 1], rowHeight), new StringFormat() { Trimming = StringTrimming.EllipsisCharacter });
                    }

                }

                bmp.Save(outputPath, ImageFormat.Png);
            }
        }


        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            if (lstOutput.Columns.Count <= 0 && lstOutput.Items.Count <= 0) return;
            if(cboOutputFolder.SelectedIndex < 0) return;

            var ofd = new SaveFileDialog
            {
                InitialDirectory = Properties.Settings.Default.OUTPUT_FOLDERS[cboOutputFolder.SelectedIndex],
                Filter = "PNG files (*.png)|*.png"
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var filename = ofd.FileName;
                ListViewToAsciiTableImage(lstOutput, filename, txtOutputLabel.Text);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConnect_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
