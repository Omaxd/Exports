namespace DXApplication2
{
    partial class Form1
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
            this.gcExports = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcExportName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbePlaces = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deDateTo = new DevExpress.XtraEditors.DateEdit();
            this.deDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.sbSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.lcPlaceName = new DevExpress.XtraEditors.LabelControl();
            this.lcDateTo = new DevExpress.XtraEditors.LabelControl();
            this.lcDateFrom = new DevExpress.XtraEditors.LabelControl();
            this.lcFoundExports = new DevExpress.XtraEditors.LabelControl();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.lcPage = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcExports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePlaces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcExports
            // 
            this.gcExports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExports.Location = new System.Drawing.Point(2, 2);
            this.gcExports.MainView = this.gridView1;
            this.gcExports.Name = "gcExports";
            this.gcExports.Size = new System.Drawing.Size(636, 492);
            this.gcExports.TabIndex = 0;
            this.gcExports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcExportName,
            this.gcDate,
            this.gcTime,
            this.gcUser,
            this.gcPlace});
            this.gridView1.GridControl = this.gcExports;
            this.gridView1.Name = "gridView1";
            // 
            // gcExportName
            // 
            this.gcExportName.Caption = "gcExportName";
            this.gcExportName.FieldName = "Name";
            this.gcExportName.Name = "gcExportName";
            this.gcExportName.Visible = true;
            this.gcExportName.VisibleIndex = 0;
            // 
            // gcDate
            // 
            this.gcDate.Caption = "gcDate";
            this.gcDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gcDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcDate.FieldName = "Date";
            this.gcDate.Name = "gcDate";
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 1;
            // 
            // gcTime
            // 
            this.gcTime.Caption = "gcTime";
            this.gcTime.DisplayFormat.FormatString = "hh:mm";
            this.gcTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gcTime.FieldName = "Date";
            this.gcTime.Name = "gcTime";
            this.gcTime.Visible = true;
            this.gcTime.VisibleIndex = 2;
            // 
            // gcUser
            // 
            this.gcUser.Caption = "gcUser";
            this.gcUser.FieldName = "UserName";
            this.gcUser.Name = "gcUser";
            this.gcUser.Visible = true;
            this.gcUser.VisibleIndex = 3;
            // 
            // gcPlace
            // 
            this.gcPlace.Caption = "gcPlace";
            this.gcPlace.FieldName = "PlaceName";
            this.gcPlace.Name = "gcPlace";
            this.gcPlace.Visible = true;
            this.gcPlace.VisibleIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lcPage);
            this.panelControl1.Controls.Add(this.lcFoundExports);
            this.panelControl1.Controls.Add(this.cbePlaces);
            this.panelControl1.Controls.Add(this.sbNext);
            this.panelControl1.Controls.Add(this.deDateTo);
            this.panelControl1.Controls.Add(this.sbPrevious);
            this.panelControl1.Controls.Add(this.deDateFrom);
            this.panelControl1.Controls.Add(this.sbSubmit);
            this.panelControl1.Controls.Add(this.lcPlaceName);
            this.panelControl1.Controls.Add(this.lcDateTo);
            this.panelControl1.Controls.Add(this.lcDateFrom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(161, 496);
            this.panelControl1.TabIndex = 1;
            // 
            // cbePlaces
            // 
            this.cbePlaces.Location = new System.Drawing.Point(12, 22);
            this.cbePlaces.Name = "cbePlaces";
            this.cbePlaces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbePlaces.Size = new System.Drawing.Size(135, 20);
            this.cbePlaces.TabIndex = 12;
            this.cbePlaces.BeforePopup += new System.EventHandler(this.cbePlaces_BeforePopup);
            // 
            // deDateTo
            // 
            this.deDateTo.EditValue = null;
            this.deDateTo.Location = new System.Drawing.Point(12, 136);
            this.deDateTo.Name = "deDateTo";
            this.deDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateTo.Size = new System.Drawing.Size(135, 20);
            this.deDateTo.TabIndex = 9;
            // 
            // deDateFrom
            // 
            this.deDateFrom.EditValue = null;
            this.deDateFrom.Location = new System.Drawing.Point(12, 78);
            this.deDateFrom.Name = "deDateFrom";
            this.deDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateFrom.Size = new System.Drawing.Size(135, 20);
            this.deDateFrom.TabIndex = 8;
            // 
            // sbSubmit
            // 
            this.sbSubmit.Location = new System.Drawing.Point(12, 171);
            this.sbSubmit.Name = "sbSubmit";
            this.sbSubmit.Size = new System.Drawing.Size(135, 23);
            this.sbSubmit.TabIndex = 2;
            this.sbSubmit.Text = "sbSubmit";
            this.sbSubmit.Click += new System.EventHandler(this.sbSubmit_Click);
            // 
            // lcPlaceName
            // 
            this.lcPlaceName.Location = new System.Drawing.Point(12, 3);
            this.lcPlaceName.Name = "lcPlaceName";
            this.lcPlaceName.Size = new System.Drawing.Size(59, 13);
            this.lcPlaceName.TabIndex = 4;
            this.lcPlaceName.Text = "lcPlaceName";
            // 
            // lcDateTo
            // 
            this.lcDateTo.Location = new System.Drawing.Point(12, 117);
            this.lcDateTo.Name = "lcDateTo";
            this.lcDateTo.Size = new System.Drawing.Size(42, 13);
            this.lcDateTo.TabIndex = 2;
            this.lcDateTo.Text = "lcDateTo";
            // 
            // lcDateFrom
            // 
            this.lcDateFrom.Location = new System.Drawing.Point(12, 59);
            this.lcDateFrom.Name = "lcDateFrom";
            this.lcDateFrom.Size = new System.Drawing.Size(54, 13);
            this.lcDateFrom.TabIndex = 0;
            this.lcDateFrom.Text = "lcDateFrom";
            // 
            // lcFoundExports
            // 
            this.lcFoundExports.Location = new System.Drawing.Point(12, 274);
            this.lcFoundExports.Name = "lcFoundExports";
            this.lcFoundExports.Size = new System.Drawing.Size(74, 13);
            this.lcFoundExports.TabIndex = 3;
            this.lcFoundExports.Text = "lcFoundExports";
            // 
            // sbNext
            // 
            this.sbNext.Location = new System.Drawing.Point(86, 236);
            this.sbNext.Name = "sbNext";
            this.sbNext.Size = new System.Drawing.Size(61, 23);
            this.sbNext.TabIndex = 2;
            this.sbNext.Text = "sbNext";
            this.sbNext.Click += new System.EventHandler(this.sbNext_Click);
            // 
            // sbPrevious
            // 
            this.sbPrevious.Location = new System.Drawing.Point(12, 236);
            this.sbPrevious.Name = "sbPrevious";
            this.sbPrevious.Size = new System.Drawing.Size(68, 23);
            this.sbPrevious.TabIndex = 1;
            this.sbPrevious.Text = "sbPrevious";
            this.sbPrevious.Click += new System.EventHandler(this.sbPrevious_Click);
            // 
            // lcPage
            // 
            this.lcPage.Location = new System.Drawing.Point(12, 217);
            this.lcPage.Name = "lcPage";
            this.lcPage.Size = new System.Drawing.Size(31, 13);
            this.lcPage.TabIndex = 0;
            this.lcPage.Text = "lcPage";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcExports);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(161, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(640, 496);
            this.panelControl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "xfTitle";
            ((System.ComponentModel.ISupportInitialize)(this.gcExports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePlaces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcExports;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbSubmit;
        private DevExpress.XtraEditors.LabelControl lcPlaceName;
        private DevExpress.XtraEditors.LabelControl lcDateTo;
        private DevExpress.XtraEditors.LabelControl lcDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gcExportName;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcTime;
        private DevExpress.XtraGrid.Columns.GridColumn gcUser;
        private DevExpress.XtraGrid.Columns.GridColumn gcPlace;
        private DevExpress.XtraEditors.DateEdit deDateFrom;
        private DevExpress.XtraEditors.DateEdit deDateTo;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.SimpleButton sbPrevious;
        private DevExpress.XtraEditors.LabelControl lcPage;
        private DevExpress.XtraEditors.ComboBoxEdit cbePlaces;
        private DevExpress.XtraEditors.LabelControl lcFoundExports;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}

