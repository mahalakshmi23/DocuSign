/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/10/2016
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DocuSignCodingChallenge
{
	partial class DressUP
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnEvaluate;
		private System.Windows.Forms.TextBox txtOutput;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblInput = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnEvaluate = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblInput
			// 
			this.lblInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInput.Location = new System.Drawing.Point(12, 21);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(171, 26);
			this.lblInput.TabIndex = 1;
			this.lblInput.Text = "Please enter the input";
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInput.Location = new System.Drawing.Point(12, 64);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(244, 34);
			this.txtInput.TabIndex = 2;
			// 
			// btnEvaluate
			// 
			this.btnEvaluate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvaluate.Location = new System.Drawing.Point(97, 121);
			this.btnEvaluate.Name = "btnEvaluate";
			this.btnEvaluate.Size = new System.Drawing.Size(75, 34);
			this.btnEvaluate.TabIndex = 3;
			this.btnEvaluate.Text = "Evaluate";
			this.btnEvaluate.UseVisualStyleBackColor = true;
			this.btnEvaluate.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutput.Location = new System.Drawing.Point(12, 181);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(244, 41);
			this.txtOutput.TabIndex = 4;
			this.txtOutput.Visible = false;
			// 
			// DressUP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnEvaluate);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.lblInput);
			this.Name = "DressUP";
			this.Text = "Dress Up";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
