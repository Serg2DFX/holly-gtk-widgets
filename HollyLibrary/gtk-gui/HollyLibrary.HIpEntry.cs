// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HollyLibrary {
    
    
    public partial class HIpEntry {
        
        private Gtk.HBox hbox3;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Entry entry1;
        
        private Gtk.Label label3;
        
        private Gtk.Entry entry2;
        
        private Gtk.Label label4;
        
        private Gtk.Entry entry3;
        
        private Gtk.Label label5;
        
        private Gtk.Entry entry4;
        
        private Gtk.Label Spacer;
        
        private Gtk.EventBox EbIcon;
        
        private Gtk.Image ErrorImage;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.HIpEntry
            Stetic.BinContainer.Attach(this);
            this.Name = "HollyLibrary.HIpEntry";
            // Container child HollyLibrary.HIpEntry.Gtk.Container+ContainerChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 1;
            this.hbox3.BorderWidth = ((uint)(6));
            // Container child hbox3.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.entry1 = new Gtk.Entry();
            this.entry1.CanFocus = true;
            this.entry1.Name = "entry1";
            this.entry1.IsEditable = true;
            this.entry1.WidthChars = 3;
            this.entry1.MaxLength = 3;
            this.entry1.HasFrame = false;
            this.entry1.InvisibleChar = '●';
            this.entry1.Xalign = 0.5F;
            this.hbox4.Add(this.entry1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox4[this.entry1]));
            w1.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = ".";
            this.hbox4.Add(this.label3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox4[this.label3]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.entry2 = new Gtk.Entry();
            this.entry2.CanFocus = true;
            this.entry2.Name = "entry2";
            this.entry2.IsEditable = true;
            this.entry2.WidthChars = 3;
            this.entry2.MaxLength = 3;
            this.entry2.HasFrame = false;
            this.entry2.InvisibleChar = '●';
            this.entry2.Xalign = 0.5F;
            this.hbox4.Add(this.entry2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox4[this.entry2]));
            w3.Position = 2;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = ".";
            this.hbox4.Add(this.label4);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox4[this.label4]));
            w4.Position = 3;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.entry3 = new Gtk.Entry();
            this.entry3.CanFocus = true;
            this.entry3.Name = "entry3";
            this.entry3.IsEditable = true;
            this.entry3.WidthChars = 3;
            this.entry3.MaxLength = 3;
            this.entry3.HasFrame = false;
            this.entry3.InvisibleChar = '●';
            this.entry3.Xalign = 0.5F;
            this.hbox4.Add(this.entry3);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox4[this.entry3]));
            w5.Position = 4;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = ".";
            this.hbox4.Add(this.label5);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox4[this.label5]));
            w6.Position = 5;
            w6.Expand = false;
            w6.Fill = false;
            this.hbox3.Add(this.hbox4);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.hbox4]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.entry4 = new Gtk.Entry();
            this.entry4.CanFocus = true;
            this.entry4.Name = "entry4";
            this.entry4.IsEditable = true;
            this.entry4.WidthChars = 3;
            this.entry4.MaxLength = 3;
            this.entry4.HasFrame = false;
            this.entry4.InvisibleChar = '●';
            this.entry4.Xalign = 0.5F;
            this.hbox3.Add(this.entry4);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.entry4]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.Spacer = new Gtk.Label();
            this.Spacer.Name = "Spacer";
            this.Spacer.LabelProp = "";
            this.hbox3.Add(this.Spacer);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox3[this.Spacer]));
            w9.Position = 2;
            // Container child hbox3.Gtk.Box+BoxChild
            this.EbIcon = new Gtk.EventBox();
            this.EbIcon.Name = "EbIcon";
            this.EbIcon.VisibleWindow = false;
            // Container child EbIcon.Gtk.Container+ContainerChild
            this.ErrorImage = new Gtk.Image();
            this.ErrorImage.Name = "ErrorImage";
            this.EbIcon.Add(this.ErrorImage);
            this.hbox3.Add(this.EbIcon);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox3[this.EbIcon]));
            w11.Position = 3;
            w11.Expand = false;
            w11.Fill = false;
            this.Add(this.hbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
