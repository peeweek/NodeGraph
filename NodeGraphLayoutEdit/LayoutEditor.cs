/*

Copyright (c) 2011, Thomas ICHE
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the 
following conditions are met:

        * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
        * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer 
          in the documentation and/or other materials provided with the distribution.
        * Neither the name of PeeWeeK.NET nor the names of its contributors may be used to endorse or promote products derived from this 
          software without specific prior written permission.


THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS;
OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT 
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NodeGraphControl;

namespace NodeGraphLayoutEdit
{
    public partial class LayoutEditor : Form
    {
        Point m_MouseLoc;
        CustomNodes.ReferenceRoot m_ReferenceRoot;

        public LayoutEditor()
        {
            InitializeComponent();
            this.nodeGraphPanel.View.RegisterDataType(new NodeGraphDataTypes.NodeGraphDataTypeFloat());
            this.nodeGraphPanel.View.RegisterDataType(new NodeGraphDataTypes.NodeGraphDataTypeBool());
            m_ReferenceRoot = new CustomNodes.ReferenceRoot(200, 0, nodeGraphPanel.View);
            this.nodeGraphPanel.AddNode(m_ReferenceRoot);

            m_MouseLoc = Point.Empty;
        }



        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void dummyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new NodeGraphNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.AdditionNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void nodeGraphPanel_onSelectionChanged(object sender, NodeGraphPanelSelectionEventArgs args)
        {
            if (args.NewSelectionCount == 1)
            {
                this.propertyGrid1.SelectedObject = this.nodeGraphPanel.View.SelectedItems[0];
            }
        }

        private void nodeGraphPanel_onSelectionCleared(object sender, NodeGraphPanelSelectionEventArgs args)
        {
            this.propertyGrid1.SelectedObject = this.nodeGraphPanel;
        }

        private void integerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.FloatConstNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }


        private void booleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.BoolConstNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void floatSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.FloatSwitchNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }


        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.SubtractNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }


        private void multiplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.MultiplyNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void divideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.DivideNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void absToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.AbsNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.PowerNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void ifSampleOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point v_ViewPos = nodeGraphPanel.ControlToView(m_MouseLoc);
            this.nodeGraphPanel.AddNode(new CustomNodes.IfNode(v_ViewPos.X, v_ViewPos.Y, nodeGraphPanel.View, true));
        }

        private void nodeGraphPanel_MouseMove(object sender, MouseEventArgs e)
        {
            m_MouseLoc = e.Location;
        }

        private void toolStripButtonTestProcess_Click(object sender, EventArgs e)
        {
            Data.NodeGraphTestResultData v_Result = m_ReferenceRoot.Process() as Data.NodeGraphTestResultData;

            string v_StdOut = "Output Values:";
            
            int i = 0;

            foreach(float i_Data in v_Result.m_Data.Values) {
                v_StdOut += "\n[" + i.ToString() + "]:" + i_Data.ToString() + "\n";
                i++;
            }

            string v_StdErr = "\n\nERRORS:\n";
            i = 0;
            foreach (string i_Error in v_Result.m_Errors.ErrorMessages)
            {
                v_StdErr += i_Error + "\n";
            }

            MessageBox.Show(v_StdOut + v_StdErr);
           
        }

        private void toolStripButtonSaveLayout_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialog.FileName))
                {
                    if (MessageBox.Show(saveFileDialog.FileName + " Exists, overwrite?", "Overwrite Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }

                this.nodeGraphPanel.SaveCurrentView(saveFileDialog.FileName); 
            }
            
        }

        private void toolStripButtonLoadXml_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.nodeGraphPanel.LoadCurrentView(openFileDialog.FileName); 

            }

            // Get Back Reference root
            foreach (NodeGraphNode i_Node in this.nodeGraphPanel.View.NodeCollection) {
                if (i_Node is CustomNodes.ReferenceRoot)
                {
                    this.m_ReferenceRoot = i_Node as CustomNodes.ReferenceRoot;
                }
            }
            
        }

        private void toolStripButtonAlignV_Click(object sender, EventArgs e)
        {
            int count = 0;
            int medX = 0;

            foreach (NodeGraphNode i_node in nodeGraphPanel.View.SelectedItems)
            {
                count++;
                medX += i_node.X;
            }

			if (count > 0)
			{
				medX = (int)(medX / count);
				foreach (NodeGraphNode i_node in nodeGraphPanel.View.SelectedItems)
				{
					i_node.X = medX;
				}
			}

            nodeGraphPanel.Refresh();
        }



        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nodeGraphPanel.View.CopySelectionToClipboard();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nodeGraphPanel.View.PasteSelectionFromClipBoard();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }












    }
}
