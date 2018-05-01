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
namespace NodeGraphLayoutEdit
{
    partial class LayoutEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutEditor));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dummyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathOperatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.absToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifSampleOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTestProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveLayout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadXml = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignV = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDistributeV = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeGraphPanel = new NodeGraphControl.NodeGraphPanel();
            this.floatSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 641);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dummyToolStripMenuItem,
            this.mathOperatorsToolStripMenuItem,
            this.ifSampleOperatorToolStripMenuItem,
            this.integerToolStripMenuItem,
            this.booleanToolStripMenuItem,
            this.floatSwitchToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(182, 158);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // dummyToolStripMenuItem
            // 
            this.dummyToolStripMenuItem.Name = "dummyToolStripMenuItem";
            this.dummyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dummyToolStripMenuItem.Text = "Dummy";
            this.dummyToolStripMenuItem.Click += new System.EventHandler(this.dummyToolStripMenuItem_Click);
            // 
            // mathOperatorsToolStripMenuItem
            // 
            this.mathOperatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.subtractToolStripMenuItem,
            this.multiplyToolStripMenuItem,
            this.divideToolStripMenuItem,
            this.toolStripSeparator1,
            this.absToolStripMenuItem,
            this.powerToolStripMenuItem});
            this.mathOperatorsToolStripMenuItem.Name = "mathOperatorsToolStripMenuItem";
            this.mathOperatorsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mathOperatorsToolStripMenuItem.Text = "Math Operators";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // multiplyToolStripMenuItem
            // 
            this.multiplyToolStripMenuItem.Name = "multiplyToolStripMenuItem";
            this.multiplyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.multiplyToolStripMenuItem.Text = "Multiply";
            this.multiplyToolStripMenuItem.Click += new System.EventHandler(this.multiplyToolStripMenuItem_Click);
            // 
            // divideToolStripMenuItem
            // 
            this.divideToolStripMenuItem.Name = "divideToolStripMenuItem";
            this.divideToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.divideToolStripMenuItem.Text = "Divide";
            this.divideToolStripMenuItem.Click += new System.EventHandler(this.divideToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // absToolStripMenuItem
            // 
            this.absToolStripMenuItem.Name = "absToolStripMenuItem";
            this.absToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.absToolStripMenuItem.Text = "Abs";
            this.absToolStripMenuItem.Click += new System.EventHandler(this.absToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // ifSampleOperatorToolStripMenuItem
            // 
            this.ifSampleOperatorToolStripMenuItem.Name = "ifSampleOperatorToolStripMenuItem";
            this.ifSampleOperatorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ifSampleOperatorToolStripMenuItem.Text = "If (Sample) Operator";
            this.ifSampleOperatorToolStripMenuItem.Click += new System.EventHandler(this.ifSampleOperatorToolStripMenuItem_Click);
            // 
            // integerToolStripMenuItem
            // 
            this.integerToolStripMenuItem.Name = "integerToolStripMenuItem";
            this.integerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.integerToolStripMenuItem.Text = "Float";
            this.integerToolStripMenuItem.Click += new System.EventHandler(this.integerToolStripMenuItem_Click);
            // 
            // booleanToolStripMenuItem
            // 
            this.booleanToolStripMenuItem.Name = "booleanToolStripMenuItem";
            this.booleanToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.booleanToolStripMenuItem.Text = "Boolean";
            this.booleanToolStripMenuItem.Click += new System.EventHandler(this.booleanToolStripMenuItem_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(722, 49);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(433, 592);
            this.propertyGrid1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTestProcess,
            this.toolStripButtonSaveLayout,
            this.toolStripButtonLoadXml,
            this.toolStripButtonAlignV,
            this.toolStripButtonDistributeV});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1155, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTestProcess
            // 
            this.toolStripButtonTestProcess.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTestProcess.Image")));
            this.toolStripButtonTestProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTestProcess.Name = "toolStripButtonTestProcess";
            this.toolStripButtonTestProcess.Size = new System.Drawing.Size(92, 22);
            this.toolStripButtonTestProcess.Text = "Test Process";
            this.toolStripButtonTestProcess.Click += new System.EventHandler(this.toolStripButtonTestProcess_Click);
            // 
            // toolStripButtonSaveLayout
            // 
            this.toolStripButtonSaveLayout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveLayout.Image")));
            this.toolStripButtonSaveLayout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveLayout.Name = "toolStripButtonSaveLayout";
            this.toolStripButtonSaveLayout.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonSaveLayout.Text = "Save";
            this.toolStripButtonSaveLayout.Click += new System.EventHandler(this.toolStripButtonSaveLayout_Click);
            // 
            // toolStripButtonLoadXml
            // 
            this.toolStripButtonLoadXml.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadXml.Image")));
            this.toolStripButtonLoadXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadXml.Name = "toolStripButtonLoadXml";
            this.toolStripButtonLoadXml.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonLoadXml.Text = "Load";
            this.toolStripButtonLoadXml.Click += new System.EventHandler(this.toolStripButtonLoadXml_Click);
            // 
            // toolStripButtonAlignV
            // 
            this.toolStripButtonAlignV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAlignV.Image")));
            this.toolStripButtonAlignV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignV.Name = "toolStripButtonAlignV";
            this.toolStripButtonAlignV.Size = new System.Drawing.Size(105, 22);
            this.toolStripButtonAlignV.Text = "Align (Vertical)";
            this.toolStripButtonAlignV.Click += new System.EventHandler(this.toolStripButtonAlignV_Click);
            // 
            // toolStripButtonDistributeV
            // 
            this.toolStripButtonDistributeV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDistributeV.Image")));
            this.toolStripButtonDistributeV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDistributeV.Name = "toolStripButtonDistributeV";
            this.toolStripButtonDistributeV.Size = new System.Drawing.Size(128, 22);
            this.toolStripButtonDistributeV.Text = "Distribute (Vertical)";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "XNG Node Graph|*.xng";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XNG Node Graph|*.xng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // nodeGraphPanel
            // 
            this.nodeGraphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(65)))), ((int)(((byte)(64)))));
            this.nodeGraphPanel.ConnectorFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.ConnectorFillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nodeGraphPanel.ConnectorHitZoneBleed = 2;
            this.nodeGraphPanel.ConnectorOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nodeGraphPanel.ConnectorOutlineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nodeGraphPanel.ConnectorTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nodeGraphPanel.ContextMenuStrip = this.contextMenuStrip;
            this.nodeGraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodeGraphPanel.DrawShadow = true;
            this.nodeGraphPanel.EnableDrawDebug = false;
            this.nodeGraphPanel.GridAlpha = ((byte)(16));
            this.nodeGraphPanel.GridPadding = 256;
            this.nodeGraphPanel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.nodeGraphPanel.LinkEditableColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.LinkHardness = 2F;
            this.nodeGraphPanel.LinkVisualStyle = NodeGraphControl.LinkVisualStyle.Curve;
            this.nodeGraphPanel.Location = new System.Drawing.Point(0, 49);
            this.nodeGraphPanel.Name = "nodeGraphPanel";
            this.nodeGraphPanel.NodeConnectorFont = new System.Drawing.Font("Tahoma", 7F);
            this.nodeGraphPanel.NodeConnectorTextZoomTreshold = 0.8F;
            this.nodeGraphPanel.NodeFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nodeGraphPanel.NodeFillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(128)))), ((int)(((byte)(100)))));
            this.nodeGraphPanel.NodeHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.NodeHeaderSize = 24;
            this.nodeGraphPanel.NodeOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.nodeGraphPanel.NodeOutlineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.nodeGraphPanel.NodeScaledConnectorFont = new System.Drawing.Font("Tahoma", 7F);
            this.nodeGraphPanel.NodeScaledTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.nodeGraphPanel.NodeSignalInvalidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.NodeSignalValidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.NodeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nodeGraphPanel.NodeTextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nodeGraphPanel.NodeTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.nodeGraphPanel.NodeTitleZoomThreshold = 0.5F;
            this.nodeGraphPanel.SelectionFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(90)))), ((int)(((byte)(30)))));
            this.nodeGraphPanel.SelectionOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.nodeGraphPanel.ShowGrid = true;
            this.nodeGraphPanel.Size = new System.Drawing.Size(722, 592);
            this.nodeGraphPanel.SmoothBehavior = false;
            this.nodeGraphPanel.TabIndex = 4;
            this.nodeGraphPanel.UseLinkColoring = true;
            this.nodeGraphPanel.onSelectionChanged += new NodeGraphControl.NodeGraphPanelSelectionEventHandler(this.nodeGraphPanel_onSelectionChanged);
            this.nodeGraphPanel.onSelectionCleared += new NodeGraphControl.NodeGraphPanelSelectionEventHandler(this.nodeGraphPanel_onSelectionCleared);
            this.nodeGraphPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nodeGraphPanel_MouseMove);
            // 
            // floatSwitchToolStripMenuItem
            // 
            this.floatSwitchToolStripMenuItem.Name = "floatSwitchToolStripMenuItem";
            this.floatSwitchToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.floatSwitchToolStripMenuItem.Text = "Float Switch";
            this.floatSwitchToolStripMenuItem.Click += new System.EventHandler(this.floatSwitchToolStripMenuItem_Click);
            // 
            // LayoutEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 663);
            this.Controls.Add(this.nodeGraphPanel);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LayoutEditor";
            this.Text = "NodeGraph Sample Layout Editor";
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dummyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathOperatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripMenuItem integerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTestProcess;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveLayout;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadXml;
        private NodeGraphControl.NodeGraphPanel nodeGraphPanel;
        private System.Windows.Forms.ToolStripMenuItem ifSampleOperatorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDistributeV;
        private System.Windows.Forms.ToolStripMenuItem booleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatSwitchToolStripMenuItem;
    }
}

