﻿using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Forms.DataVisualization.Charting;
using Axis = LiveCharts.Wpf.Axis;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace munReportDef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.AxisY = new AxesCollection
            {
                 new Axis {
                Title = "Tipos",
                Labels = new[]{"Municipios", "Islas", "Areas"},
                LabelFormatter = value => value.ToString("N")

                },


            };
            
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
                    cartesianChart1.Series.Clear();

                    SeriesCollection sc = new SeriesCollection
                    {
                        new RowSeries
                        {
                            Title = "Cantidad",
                            Values = new ChartValues<int>{1102,1,18 },
                        },
                    };
                    cartesianChart1.Series = sc;


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

        private void chart1_Click(object sender, EventArgs e)
        {/**
            ChartArea area = new ChartArea("T");
            try
            {
                chart1.ChartAreas.Add(area);
            

            Series barSeries = new Series();
            barSeries.Points.AddXY("Municipios", "200");
            barSeries.Points.AddXY("Islas", "100");
            barSeries.Points.AddXY("Areas no mun", "20");


            //chart title  
            chart1.Titles.Add("Tipos");
            }
            catch (Exception efe)
            {
            }

            */
        }
    }
}
