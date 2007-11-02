namespace PlayingWithActiveReports.Win.UI
{
	partial class SimpleReportView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.uxReportViewerControl = new DataDynamics.ActiveReports.Viewer.Viewer( );
			this.SuspendLayout( );
			// 
			// viewer1
			// 
			this.uxReportViewerControl.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.uxReportViewerControl.BackColor = System.Drawing.SystemColors.Control;
			this.uxReportViewerControl.Document = new DataDynamics.ActiveReports.Document.Document( "ARNet Document" );
			this.uxReportViewerControl.Location = new System.Drawing.Point( 0, 0 );
			this.uxReportViewerControl.Name = "uxReportViewerControl";
			this.uxReportViewerControl.ReportViewer.CurrentPage = 0;
			this.uxReportViewerControl.ReportViewer.MultiplePageCols = 3;
			this.uxReportViewerControl.ReportViewer.MultiplePageRows = 2;
			this.uxReportViewerControl.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
			this.uxReportViewerControl.Size = new System.Drawing.Size( 799, 552 );
			this.uxReportViewerControl.TabIndex = 0;
			this.uxReportViewerControl.TableOfContents.Text = "Table Of Contents";
			this.uxReportViewerControl.TableOfContents.Width = 200;
			this.uxReportViewerControl.TabTitleLength = 35;
			this.uxReportViewerControl.Toolbar.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			// 
			// SimpleReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 811, 564 );
			this.Controls.Add( this.uxReportViewerControl );
			this.Name = "SimpleReportView";
			this.Text = "SimpleReportView";
			this.ResumeLayout( false );

		}

		#endregion

		private DataDynamics.ActiveReports.Viewer.Viewer uxReportViewerControl;
	}
}