namespace AppTitlesAnime {
	partial class FormListGenres {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			btnUpdateType = new Button();
			panelFill = new Panel();
			dataGridViewGenres = new DataGridView();
			flowLayoutPanelTop = new FlowLayoutPanel();
			btnAddType = new Button();
			btnDeleteType = new Button();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
			flowLayoutPanelTop.SuspendLayout();
			SuspendLayout();
			// 
			// btnUpdateType
			// 
			btnUpdateType.AutoSize = true;
			btnUpdateType.Location = new Point(125, 13);
			btnUpdateType.Name = "btnUpdateType";
			btnUpdateType.Size = new Size(151, 35);
			btnUpdateType.TabIndex = 1;
			btnUpdateType.Text = "Редактировать";
			btnUpdateType.UseVisualStyleBackColor = true;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridViewGenres);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 61);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(10);
			panelFill.Size = new Size(923, 523);
			panelFill.TabIndex = 4;
			// 
			// dataGridViewGenres
			// 
			dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewGenres.BackgroundColor = Color.White;
			dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewGenres.Dock = DockStyle.Fill;
			dataGridViewGenres.Location = new Point(10, 10);
			dataGridViewGenres.MultiSelect = false;
			dataGridViewGenres.Name = "dataGridViewGenres";
			dataGridViewGenres.ReadOnly = true;
			dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewGenres.Size = new Size(903, 503);
			dataGridViewGenres.TabIndex = 1;
			// 
			// flowLayoutPanelTop
			// 
			flowLayoutPanelTop.AutoSize = true;
			flowLayoutPanelTop.BackColor = Color.White;
			flowLayoutPanelTop.Controls.Add(btnAddType);
			flowLayoutPanelTop.Controls.Add(btnUpdateType);
			flowLayoutPanelTop.Controls.Add(btnDeleteType);
			flowLayoutPanelTop.Dock = DockStyle.Top;
			flowLayoutPanelTop.ForeColor = SystemColors.ControlText;
			flowLayoutPanelTop.Location = new Point(0, 0);
			flowLayoutPanelTop.Name = "flowLayoutPanelTop";
			flowLayoutPanelTop.Padding = new Padding(10);
			flowLayoutPanelTop.Size = new Size(923, 61);
			flowLayoutPanelTop.TabIndex = 3;
			// 
			// btnAddType
			// 
			btnAddType.AutoSize = true;
			btnAddType.Location = new Point(13, 13);
			btnAddType.Name = "btnAddType";
			btnAddType.Size = new Size(106, 35);
			btnAddType.TabIndex = 0;
			btnAddType.Text = "Добавить";
			btnAddType.UseVisualStyleBackColor = true;
			// 
			// btnDeleteType
			// 
			btnDeleteType.AutoSize = true;
			btnDeleteType.Location = new Point(282, 13);
			btnDeleteType.Name = "btnDeleteType";
			btnDeleteType.Size = new Size(92, 35);
			btnDeleteType.TabIndex = 2;
			btnDeleteType.Text = "Удалить";
			btnDeleteType.UseVisualStyleBackColor = true;
			// 
			// FormListGenres
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(923, 584);
			Controls.Add(panelFill);
			Controls.Add(flowLayoutPanelTop);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(5);
			Name = "FormListGenres";
			Text = "Список жанров аниме";
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
			flowLayoutPanelTop.ResumeLayout(false);
			flowLayoutPanelTop.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnUpdateType;
		private Panel panelFill;
		private DataGridView dataGridViewGenres;
		private FlowLayoutPanel flowLayoutPanelTop;
		private Button btnAddType;
		private Button btnDeleteType;
	}
}