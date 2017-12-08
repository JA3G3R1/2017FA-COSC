namespace EventsSchedulerUI
{
    partial class EventAdminView
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbView = new System.Windows.Forms.TabControl();
            this.tbList = new System.Windows.Forms.TabPage();
            this.tbTeaser = new System.Windows.Forms.TabPage();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnRegisterRequest = new System.Windows.Forms.Button();
            this.tbView.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // tbView
            // 
            this.tbView.Controls.Add(this.tbList);
            this.tbView.Controls.Add(this.tbTeaser);
            this.tbView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbView.Location = new System.Drawing.Point(257, 18);
            this.tbView.Name = "tbView";
            this.tbView.SelectedIndex = 0;
            this.tbView.Size = new System.Drawing.Size(624, 587);
            this.tbView.TabIndex = 1;
            // 
            // tbList
            // 
            this.tbList.Location = new System.Drawing.Point(4, 22);
            this.tbList.Name = "tbList";
            this.tbList.Padding = new System.Windows.Forms.Padding(3);
            this.tbList.Size = new System.Drawing.Size(616, 561);
            this.tbList.TabIndex = 0;
            this.tbList.Text = "List View";
            this.tbList.UseVisualStyleBackColor = true;
            // 
            // tbTeaser
            // 
            this.tbTeaser.Location = new System.Drawing.Point(4, 27);
            this.tbTeaser.Name = "tbTeaser";
            this.tbTeaser.Padding = new System.Windows.Forms.Padding(3);
            this.tbTeaser.Size = new System.Drawing.Size(616, 556);
            this.tbTeaser.TabIndex = 1;
            this.tbTeaser.Text = "Teaser";
            this.tbTeaser.UseVisualStyleBackColor = true;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.Location = new System.Drawing.Point(18, 192);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(227, 28);
            this.btnCreateEvent.TabIndex = 2;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(18, 226);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(227, 28);
            this.btnUpdateEvent.TabIndex = 3;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.Location = new System.Drawing.Point(18, 260);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(227, 28);
            this.btnDeleteEvent.TabIndex = 4;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // btnRegisterRequest
            // 
            this.btnRegisterRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterRequest.Location = new System.Drawing.Point(18, 294);
            this.btnRegisterRequest.Name = "btnRegisterRequest";
            this.btnRegisterRequest.Size = new System.Drawing.Size(227, 28);
            this.btnRegisterRequest.TabIndex = 5;
            this.btnRegisterRequest.Text = "Registrar";
            this.btnRegisterRequest.UseVisualStyleBackColor = true;
            // 
            // EventAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 617);
            this.Controls.Add(this.btnRegisterRequest);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.tbView);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "EventAdminView";
            this.Text = "Event Administrator";
            this.tbView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabControl tbView;
        private System.Windows.Forms.TabPage tbList;
        private System.Windows.Forms.TabPage tbTeaser;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnRegisterRequest;
    }
}