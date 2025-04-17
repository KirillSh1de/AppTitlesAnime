namespace AppTitlesAnime {
	partial class FormAddGenres {
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
			textBoxGenresName = new TextBox();
			labelGenresName = new Label();
			panelFill = new Panel();
			btnSaveChanges = new Button();
			btnCancel = new Button();
			flowLayoutPanelBottom = new FlowLayoutPanel();
			panelFill.SuspendLayout();
			flowLayoutPanelBottom.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxGenresName
			// 
			textBoxGenresName.Dock = DockStyle.Top;
			textBoxGenresName.Location = new Point(10, 35);
			textBoxGenresName.Margin = new Padding(3, 15, 3, 3);
			textBoxGenresName.Name = "textBoxGenresName";
			textBoxGenresName.Size = new Size(418, 33);
			textBoxGenresName.TabIndex = 1;
			// 
			// labelGenresName
			// 
			labelGenresName.AutoSize = true;
			labelGenresName.Dock = DockStyle.Top;
			labelGenresName.Location = new Point(10, 10);
			labelGenresName.Name = "labelGenresName";
			labelGenresName.Size = new Size(120, 25);
			labelGenresName.TabIndex = 0;
			labelGenresName.Text = "Жанр аниме";
			// 
			// panelFill
			// 
			panelFill.Controls.Add(textBoxGenresName);
			panelFill.Controls.Add(labelGenresName);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 0);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(10, 10, 20, 10);
			panelFill.Size = new Size(448, 83);
			panelFill.TabIndex = 2;
			// 
			// btnSaveChanges
			// 
			btnSaveChanges.AutoSize = true;
			btnSaveChanges.DialogResult = DialogResult.OK;
			btnSaveChanges.Location = new Point(13, 13);
			btnSaveChanges.Name = "btnSaveChanges";
			btnSaveChanges.Size = new Size(115, 35);
			btnSaveChanges.TabIndex = 0;
			btnSaveChanges.Text = "Сохранить";
			btnSaveChanges.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			btnCancel.AutoSize = true;
			btnCancel.DialogResult = DialogResult.Cancel;
			btnCancel.Location = new Point(134, 13);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(88, 35);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Отмена";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanelBottom
			// 
			flowLayoutPanelBottom.AutoSize = true;
			flowLayoutPanelBottom.Controls.Add(btnSaveChanges);
			flowLayoutPanelBottom.Controls.Add(btnCancel);
			flowLayoutPanelBottom.Dock = DockStyle.Bottom;
			flowLayoutPanelBottom.Location = new Point(0, 83);
			flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
			flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
			flowLayoutPanelBottom.Size = new Size(448, 61);
			flowLayoutPanelBottom.TabIndex = 3;
			// 
			// FormAddGenres
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(448, 144);
			Controls.Add(panelFill);
			Controls.Add(flowLayoutPanelBottom);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(5);
			Name = "FormAddGenres";
			Text = "Информация о жанре аниме";
			panelFill.ResumeLayout(false);
			panelFill.PerformLayout();
			flowLayoutPanelBottom.ResumeLayout(false);
			flowLayoutPanelBottom.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		protected internal TextBox textBoxGenresName;
		private Label labelGenresName;
		private Panel panelFill;
		private Button btnSaveChanges;
		private Button btnCancel;
		private FlowLayoutPanel flowLayoutPanelBottom;
	}
}