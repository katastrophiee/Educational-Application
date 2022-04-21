namespace Task2_Code
{
    partial class graph_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graph_screen));
            this.student_data_graph = new ZedGraph.ZedGraphControl();
            this.student_name = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student_data_graph
            // 
            this.student_data_graph.Location = new System.Drawing.Point(22, 209);
            this.student_data_graph.Name = "student_data_graph";
            this.student_data_graph.ScrollGrace = 0D;
            this.student_data_graph.ScrollMaxX = 0D;
            this.student_data_graph.ScrollMaxY = 0D;
            this.student_data_graph.ScrollMaxY2 = 0D;
            this.student_data_graph.ScrollMinX = 0D;
            this.student_data_graph.ScrollMinY = 0D;
            this.student_data_graph.ScrollMinY2 = 0D;
            this.student_data_graph.Size = new System.Drawing.Size(1215, 451);
            this.student_data_graph.TabIndex = 15;
            this.student_data_graph.UseExtendedPrintDialog = true;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(16, 173);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(85, 33);
            this.student_name.TabIndex = 16;
            this.student_name.Text = "label1";
            this.student_name.Visible = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.back_btn.Location = new System.Drawing.Point(22, 141);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(110, 68);
            this.back_btn.TabIndex = 20;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // graph_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.student_data_graph);
            this.Controls.Add(this.student_name);
            this.Name = "graph_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.Shown += new System.EventHandler(this.graph_screen_Shown);
            this.Controls.SetChildIndex(this.student_name, 0);
            this.Controls.SetChildIndex(this.student_data_graph, 0);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.back_btn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl student_data_graph;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Button back_btn;
    }
}