﻿
namespace Nettiers.AdventureWorks.Windows.Forms
{
	/// <summary>
	/// This is the abstract edit form for the <see cref="Entities.Location"/> entity.
	/// </summary>
	/// <remarks>This class is overwritten by .netTiers at each generation.</remarks>
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public abstract class LocationEditControlBase : System.Windows.Forms.UserControl
	{
		#region Fields
		
		//private System.Windows.Forms.TableLayoutPanel uxTableLayoutPanel;
		/// <summary>
		/// The ErrorProvider for the Entity;
		/// </summary>
		protected System.Windows.Forms.ErrorProvider uxErrorProvider;
		
		/// <summary>
		/// The BindingSource for the entity.
		///</summary>
		protected System.Windows.Forms.BindingSource uxBindingSource;
						
		
		/// <summary>
		/// TextBox for the LocationId property. 
		/// </summary>
		protected System.Windows.Forms.TextBox uxLocationId;
		
		/// <summary>
		/// The <see cref="System.Windows.Forms.Label"/> associated with the LocationId property.
		/// </summary>
		protected System.Windows.Forms.Label uxLocationIdLabel;
		
		/// <summary>
		/// TextBox for the Name property. 
		/// </summary>
		protected System.Windows.Forms.TextBox uxName;
		
		/// <summary>
		/// The <see cref="System.Windows.Forms.Label"/> associated with the Name property.
		/// </summary>
		protected System.Windows.Forms.Label uxNameLabel;
		
		/// <summary>
		/// TextBox for the CostRate property. 
		/// </summary>
		protected System.Windows.Forms.TextBox uxCostRate;
		
		/// <summary>
		/// The <see cref="System.Windows.Forms.Label"/> associated with the CostRate property.
		/// </summary>
		protected System.Windows.Forms.Label uxCostRateLabel;
		
		/// <summary>
		/// TextBox for the Availability property. 
		/// </summary>
		protected System.Windows.Forms.TextBox uxAvailability;
		
		/// <summary>
		/// The <see cref="System.Windows.Forms.Label"/> associated with the Availability property.
		/// </summary>
		protected System.Windows.Forms.Label uxAvailabilityLabel;
		
		/// <summary>
		/// DataTimePicker for the ModifiedDate property.
		/// </summary>
		protected System.Windows.Forms.DateTimePicker uxModifiedDate;
		
		/// <summary>
		/// The <see cref="System.Windows.Forms.Label"/> associated with the ModifiedDate property.
		/// </summary>
		protected System.Windows.Forms.Label uxModifiedDateLabel;
		#endregion
		
		#region Main entity
		private Entities.Location _Location;
		/// <summary>
		/// Gets or sets the <see cref="Entities.Location"/> entity to edit with this form.
		/// </summary>
		/// <value>The <see cref="Entities.Location"/> instance.</value>
		public Entities.Location Location
		{
			get {return this._Location;}
			set
			{
				this._Location = value;
				if (value != null) 
				{
					this.uxBindingSource.DataSource = value;
					BindControls();
				}			
				
			}
		}
		#endregion
		
		/// <summary>
		/// Binds the controls.
		/// </summary>
		private void BindControls()
		{
			this.uxLocationId.DataBindings.Clear();
			this.uxLocationId.DataBindings.Add("Text", this.uxBindingSource, "LocationId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			this.uxName.DataBindings.Clear();
			this.uxName.DataBindings.Add("Text", this.uxBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			this.uxCostRate.DataBindings.Clear();
			this.uxCostRate.DataBindings.Add("Text", this.uxBindingSource, "CostRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			this.uxAvailability.DataBindings.Clear();
			this.uxAvailability.DataBindings.Add("Text", this.uxBindingSource, "Availability", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			this.uxModifiedDate.DataBindings.Clear();
			this.uxModifiedDate.DataBindings.Add("Value", this.uxBindingSource, "ModifiedDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
		}					
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationEditControlBase"/> class.
		/// </summary>
		public LocationEditControlBase()
		{
			InitializeComponent();			
			
			this.uxBindingSource.CurrentItemChanged += new System.EventHandler(uxBindingSource_currentItemChanged);
		}		
		
		/// <summary>
		/// 
		/// </summary>
		private void uxBindingSource_currentItemChanged(object sender, System.EventArgs e)
		{
			if (_Location != null) _Location.Validate();
		}	
				
		/// <summary>
		/// Initializes the component.
		/// </summary>
		public void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.uxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.uxBindingSource = new System.Windows.Forms.BindingSource(this.components);
			
			//this.uxTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.uxLocationId = new System.Windows.Forms.TextBox();
			uxLocationIdLabel = new System.Windows.Forms.Label();
			this.uxName = new System.Windows.Forms.TextBox();
			uxNameLabel = new System.Windows.Forms.Label();
			this.uxCostRate = new System.Windows.Forms.TextBox();
			uxCostRateLabel = new System.Windows.Forms.Label();
			this.uxAvailability = new System.Windows.Forms.TextBox();
			uxAvailabilityLabel = new System.Windows.Forms.Label();
			this.uxModifiedDate = new System.Windows.Forms.DateTimePicker();
			uxModifiedDateLabel = new System.Windows.Forms.Label();
			
			((System.ComponentModel.ISupportInitialize)(this.uxBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).BeginInit();
			this.SuspendLayout();
			
			// 
			// uxTableLayoutPanel
			// 
			//this.uxTableLayoutPanel.AutoSize = true;
			//this.uxTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			//this.uxTableLayoutPanel.ColumnCount = 2;
			//this.uxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			//this.uxTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			//this.uxTableLayoutPanel.Location = new System.Drawing.System.Drawing.Point(3, 3);
			//this.uxTableLayoutPanel.Name = "uxTableLayoutPanel";
			//this.uxTableLayoutPanel.RowCount = 2;
			//this.uxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			//this.uxTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			//this.uxTableLayoutPanel.Size = new System.Drawing.Size(450, 50);
			//this.uxTableLayoutPanel.TabIndex = 0;
			
			//
			// uxErrorProvider
			//
			this.uxErrorProvider.ContainerControl = this;
			this.uxErrorProvider.DataSource = this.uxBindingSource;
			
			//
			// uxLocationIdLabel
			//
			this.uxLocationIdLabel.Name = "uxLocationIdLabel";
			this.uxLocationIdLabel.Text = "Location Id:";
			this.uxLocationIdLabel.Location = new System.Drawing.Point(3, 0);
			this.Controls.Add(this.uxLocationIdLabel);
			//this.uxTableLayoutPanel.Controls.Add(this.uxLocationIdLabel);			
			//
			// uxLocationId
			//
			this.uxLocationId.Name = "uxLocationId";
            this.uxLocationId.ReadOnly = true;
			//this.uxTableLayoutPanel.Controls.Add(this.uxLocationId);
			this.uxLocationId.Location = new System.Drawing.Point(160, 0);
			this.Controls.Add(this.uxLocationId);
			//
			// uxNameLabel
			//
			this.uxNameLabel.Name = "uxNameLabel";
			this.uxNameLabel.Text = "Name:";
			this.uxNameLabel.Location = new System.Drawing.Point(3, 26);
			this.Controls.Add(this.uxNameLabel);
			//this.uxTableLayoutPanel.Controls.Add(this.uxNameLabel);			
			//
			// uxName
			//
			this.uxName.Name = "uxName";
			this.uxName.Width = 250;
			this.uxName.MaxLength = 50;
			//this.uxTableLayoutPanel.Controls.Add(this.uxName);
			this.uxName.Location = new System.Drawing.Point(160, 26);
			this.Controls.Add(this.uxName);
			//
			// uxCostRateLabel
			//
			this.uxCostRateLabel.Name = "uxCostRateLabel";
			this.uxCostRateLabel.Text = "Cost Rate:";
			this.uxCostRateLabel.Location = new System.Drawing.Point(3, 52);
			this.Controls.Add(this.uxCostRateLabel);
			//this.uxTableLayoutPanel.Controls.Add(this.uxCostRateLabel);			
			//
			// uxCostRate
			//
			this.uxCostRate.Name = "uxCostRate";
			//this.uxTableLayoutPanel.Controls.Add(this.uxCostRate);
			this.uxCostRate.Location = new System.Drawing.Point(160, 52);
			this.Controls.Add(this.uxCostRate);
			//
			// uxAvailabilityLabel
			//
			this.uxAvailabilityLabel.Name = "uxAvailabilityLabel";
			this.uxAvailabilityLabel.Text = "Availability:";
			this.uxAvailabilityLabel.Location = new System.Drawing.Point(3, 78);
			this.Controls.Add(this.uxAvailabilityLabel);
			//this.uxTableLayoutPanel.Controls.Add(this.uxAvailabilityLabel);			
			//
			// uxAvailability
			//
			this.uxAvailability.Name = "uxAvailability";
			//this.uxTableLayoutPanel.Controls.Add(this.uxAvailability);
			this.uxAvailability.Location = new System.Drawing.Point(160, 78);
			this.Controls.Add(this.uxAvailability);
			//
			// uxModifiedDateLabel
			//
			this.uxModifiedDateLabel.Name = "uxModifiedDateLabel";
			this.uxModifiedDateLabel.Text = "Modified Date:";
			this.uxModifiedDateLabel.Location = new System.Drawing.Point(3, 104);
			this.Controls.Add(this.uxModifiedDateLabel);
			//this.uxTableLayoutPanel.Controls.Add(this.uxModifiedDateLabel);			
			//
			// uxModifiedDate
			//
			this.uxModifiedDate.Name = "uxModifiedDate";
			//this.uxTableLayoutPanel.Controls.Add(this.uxModifiedDate);
			this.uxModifiedDate.Location = new System.Drawing.Point(160, 104);
			this.Controls.Add(this.uxModifiedDate);
			// 
			// LocationEditControlBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//this.Controls.Add(this.uxTableLayoutPanel);
			this.AutoScroll = true;
			this.Name = "LocationEditControlBase";
			this.Size = new System.Drawing.Size(478, 311);
			//this.Localizable = true;
			((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uxBindingSource)).EndInit();			
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
				
		#region ComboBox List
		
		
		#endregion
		
        #region Field visibility

        /// <summary>
        /// Indicates if the controls associated with the uxLocationId property should be visible.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Visible property for related controls.")]
        public bool uxLocationIdVisible
        {
            get { return this.uxLocationId.Visible; }
            set
            {
                this.uxLocationIdLabel.Visible = value;
                this.uxLocationId.Visible = value;
            }
        }

        /// <summary>
        /// Indicates if the controls associated with the uxLocationId property should be enabled.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Enabled property for related controls.")]
        public bool uxLocationIdEnabled
        {
            get { return this.uxLocationId.Enabled; }
            set
            {
                this.uxLocationId.Enabled = value;
            }
        }
        /// <summary>
        /// Indicates if the controls associated with the uxName property should be visible.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Visible property for related controls.")]
        public bool uxNameVisible
        {
            get { return this.uxName.Visible; }
            set
            {
                this.uxNameLabel.Visible = value;
                this.uxName.Visible = value;
            }
        }

        /// <summary>
        /// Indicates if the controls associated with the uxName property should be enabled.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Enabled property for related controls.")]
        public bool uxNameEnabled
        {
            get { return this.uxName.Enabled; }
            set
            {
                this.uxName.Enabled = value;
            }
        }
        /// <summary>
        /// Indicates if the controls associated with the uxCostRate property should be visible.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Visible property for related controls.")]
        public bool uxCostRateVisible
        {
            get { return this.uxCostRate.Visible; }
            set
            {
                this.uxCostRateLabel.Visible = value;
                this.uxCostRate.Visible = value;
            }
        }

        /// <summary>
        /// Indicates if the controls associated with the uxCostRate property should be enabled.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Enabled property for related controls.")]
        public bool uxCostRateEnabled
        {
            get { return this.uxCostRate.Enabled; }
            set
            {
                this.uxCostRate.Enabled = value;
            }
        }
        /// <summary>
        /// Indicates if the controls associated with the uxAvailability property should be visible.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Visible property for related controls.")]
        public bool uxAvailabilityVisible
        {
            get { return this.uxAvailability.Visible; }
            set
            {
                this.uxAvailabilityLabel.Visible = value;
                this.uxAvailability.Visible = value;
            }
        }

        /// <summary>
        /// Indicates if the controls associated with the uxAvailability property should be enabled.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Enabled property for related controls.")]
        public bool uxAvailabilityEnabled
        {
            get { return this.uxAvailability.Enabled; }
            set
            {
                this.uxAvailability.Enabled = value;
            }
        }
        /// <summary>
        /// Indicates if the controls associated with the uxModifiedDate property should be visible.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Visible property for related controls.")]
        public bool uxModifiedDateVisible
        {
            get { return this.uxModifiedDate.Visible; }
            set
            {
                this.uxModifiedDateLabel.Visible = value;
                this.uxModifiedDate.Visible = value;
            }
        }

        /// <summary>
        /// Indicates if the controls associated with the uxModifiedDate property should be enabled.
        /// </summary>
        [System.ComponentModel.Category(".netTiers"), System.ComponentModel.Description("Set Enabled property for related controls.")]
        public bool uxModifiedDateEnabled
        {
            get { return this.uxModifiedDate.Enabled; }
            set
            {
                this.uxModifiedDate.Enabled = value;
            }
        }

        #endregion

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
	}
}
