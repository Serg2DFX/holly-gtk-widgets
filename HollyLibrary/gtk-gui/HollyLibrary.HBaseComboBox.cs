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
    
    
    internal partial class HBaseComboBox {
        
        private Gtk.HBox hbox3;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Entry entry;
        
        private Gtk.Button popupButton;
        
        private Gtk.Arrow arrow1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.HBaseComboBox
            Stetic.BinContainer.Attach(this);
            this.Name = "HollyLibrary.HBaseComboBox";
            // Container child HollyLibrary.HBaseComboBox.Gtk.Container+ContainerChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            // Container child hbox3.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 2;
            this.hbox4.BorderWidth = ((uint)(5));
            // Container child hbox4.Gtk.Box+BoxChild
            this.entry = new Gtk.Entry();
            this.entry.CanFocus = true;
            this.entry.Name = "entry";
            this.entry.IsEditable = true;
            this.entry.HasFrame = false;
            this.entry.InvisibleChar = '●';
            this.hbox4.Add(this.entry);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox4[this.entry]));
            w1.Position = 0;
            this.hbox3.Add(this.hbox4);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox3[this.hbox4]));
            w2.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.popupButton = new Gtk.Button();
            this.popupButton.WidthRequest = 30;
            this.popupButton.CanFocus = true;
            this.popupButton.Name = "popupButton";
            // Container child popupButton.Gtk.Container+ContainerChild
            this.arrow1 = new Gtk.Arrow(((Gtk.ArrowType)(1)), ((Gtk.ShadowType)(2)));
            this.arrow1.Name = "arrow1";
            this.popupButton.Add(this.arrow1);
            this.popupButton.Label = null;
            this.hbox3.Add(this.popupButton);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.popupButton]));
            w4.Position = 1;
            w4.Expand = false;
            this.Add(this.hbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.entry.FocusInEvent += new Gtk.FocusInEventHandler(this.OnEntryFocusInEvent);
            this.entry.FocusOutEvent += new Gtk.FocusOutEventHandler(this.OnEntryFocusOutEvent);
        }
    }
}