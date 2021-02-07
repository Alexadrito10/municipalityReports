using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace munReportDef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private DataTable dT = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                String filePath = opd.FileName;


                try
                {

                    StreamReader streamReader = new StreamReader(filePath);
                    string read;
                    string[] titles;
                    if ((titles = streamReader.ReadLine().Split(',')) != null)
                    {

                        dT.Columns.Add(titles[0]);
                        dT.Columns.Add(titles[1]);
                        dT.Columns.Add(titles[2]);
                        dT.Columns.Add(titles[3]);
                        dT.Columns.Add(titles[4]);
                    }

                    //bool titles=true;
                    while ((read = streamReader.ReadLine()) != null)
                    {

                        string[] rowRaw = read.Split(',');


                        //if (titles == true)
                        /*{ 

                            for (int i = 0; i < rowRaw.Length; i++)
                            {
                                dT.Columns.Add(rowRaw[i]);

                            }
                            titles = false;



                        }
                        **/

                        dT.Rows.Add(rowRaw);
                        database.DataSource = dT;


                    }

                }
                catch (Exception o)
                {

                }

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            dT.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Municipio", cbFilter.Text);

        }
    }
}
