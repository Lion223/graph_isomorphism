using Microsoft.Glee.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using vflibcs;

namespace FormUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        Microsoft.Glee.Drawing.Graph graph;
        Microsoft.Glee.Drawing.Graph graph2;
        vflibcs.Graph g;
        vflibcs.Graph g2;
        int[,] graphArr;
        int[,] graphArr2;
        List<Edge> edgeList;
        List<Edge> edgeList2;

        public MainForm()
        {
            InitializeComponent();
        }

        struct Edge
        {
            public int x, y, i;
        }

        public void addEdge(int x, int y, int i)
        {
            Edge edge = new Edge();
            edge.x = x; edge.y = y; edge.i = i;
            edgeList.Add(edge);
            g.InsertEdge(x, y);
            g.InsertEdge(y, x);
        }

        public void addEdge2(int x, int y, int i)
        {
            Edge edge = new Edge();
            edge.x = x; edge.y = y; edge.i = i;
            edgeList2.Add(edge);
            g2.InsertEdge(x, y);
            g2.InsertEdge(y, x);
        }

        private void readfileBtn_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text document (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graph = new Microsoft.Glee.Drawing.Graph("graph");
                graphTb.Clear();
                fileTb.Clear();
                resTb.Clear();
                string fileArr;
                fileLbl.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                int size = fileArr.Split('\n').Length;
                graphArr = new int[size, size];
                g = new vflibcs.Graph();
                g.InsertNodes(size);
                int i = 0, j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        graphArr[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                foreach (var row in fileArr.Split('\n'))
                {
                    string strrow = row.Trim();
                    fileTb.AppendText(strrow + Environment.NewLine);
                }

                int n = graphArr.GetLength(0);

                edgeList = new List<Edge>();
                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (graphArr[i, j] != 0)
                        {
                            addEdge(i, j, graphArr[i, j]);
                        }
                    }
                }
                graphTb.AppendText("Node: (x, y)" + Environment.NewLine);
                foreach (Edge edge in edgeList)
                {
                    graph.AddEdge(edge.x.ToString(), edge.y.ToString());
                    string str = "(" + edge.x + ", " + edge.y + ")";
                    graphTb.AppendText(str + Environment.NewLine);
                }

                foreach (var edge in graph.Edges)
                {
                    edge.Attr.ArrowHeadAtTarget = ArrowStyle.None;
                    edge.Attr.LineWidth = 2;
                }

                graph.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer.OutsideAreaBrush = Brushes.White;
                graphViewer.Graph = graph;

                graphTb.AppendText(Environment.NewLine);
            }
        }


        private void readfileBtn2_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "Text document (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                graph2 = new Microsoft.Glee.Drawing.Graph("graph2");
                graphTb2.Clear();
                fileTb2.Clear();
                resTb.Clear();
                string fileArr;
                fileLbl2.Text = ofd.SafeFileName;
                fileArr = File.ReadAllText(ofd.FileName);
                int size = fileArr.Split('\n').Length;
                graphArr2 = new int[size, size];
                g2 = new vflibcs.Graph();
                g2.InsertNodes(size);
                int i = 0, j = 0;
                foreach (var row in fileArr.Split('\n'))
                {
                    j = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        graphArr2[i, j] = int.Parse(col.Trim());
                        j++;
                    }
                    i++;
                }
                foreach (var row in fileArr.Split('\n'))
                {
                    string strrow = row.Trim();
                    fileTb2.AppendText(strrow + Environment.NewLine);
                }

                int n = graphArr2.GetLength(0);

                edgeList2 = new List<Edge>();
                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (graphArr2[i, j] != 0)
                        {
                            addEdge2(i, j, graphArr2[i, j]);
                        }
                    }
                }
                graphTb2.AppendText("Node: (x, y)" + Environment.NewLine);
                foreach (Edge edge in edgeList2)
                {
                    graph2.AddEdge(edge.x.ToString(), edge.y.ToString());
                    string str = "(" + edge.x + ", " + edge.y + ")";
                    graphTb2.AppendText(str + Environment.NewLine);
                }

                foreach (var edge in graph2.Edges)
                {
                    edge.Attr.ArrowHeadAtTarget = ArrowStyle.None;
                    edge.Attr.LineWidth = 2;
                }

                graph2.GraphAttr.Orientation = Microsoft.Glee.Drawing.Orientation.Landscape;
                graph2.GraphAttr.LayerDirection = LayerDirection.LR;
                graphViewer2.OutsideAreaBrush = Brushes.White;
                graphViewer2.Graph = graph2;

                graphTb2.AppendText(Environment.NewLine);
            }
        }

        private void checkIsoBtn_Click(object sender, EventArgs e)
        {
            VfState vfs = new VfState(g, g2);

            bool fIsomorphic = vfs.FMatch();
            if (fIsomorphic)
            {
                resTb.AppendText("Graphs are isomorphic." + Environment.NewLine);
                int[] mapping1to2 = vfs.Mapping1To2;
                int[] mapping2to1 = vfs.Mapping2To1;
                resTb.AppendText("Compliance of nodes: " + Environment.NewLine);
                for (int i = 0; i < mapping1to2.Count(); i++)
                {
                    resTb.AppendText(i + " = " + mapping1to2[i] + Environment.NewLine);
                }
            }
            else
            {
                resTb.AppendText("Graphs are not isomorphic." + Environment.NewLine);
            }
        }
    }
}
