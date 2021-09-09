
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Frame frame1;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.CheckButton checkbutton1;

	private global::Gtk.Image image1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TextView textview2;

	private global::Gtk.Label Output_LBL;

	private global::Gtk.Label Input_Lbl;

	private global::Gtk.Button Exit_BTN;

	private global::Gtk.Button Cypher_Calc_BTN;

	private global::Gtk.Label GtkLabel1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.checkbutton1 = new global::Gtk.CheckButton();
		this.checkbutton1.CanFocus = true;
		this.checkbutton1.Name = "checkbutton1";
		this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("checkbutton1");
		this.checkbutton1.DrawIndicator = true;
		this.checkbutton1.UseUnderline = true;
		this.fixed1.Add(this.checkbutton1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.checkbutton1]));
		w1.X = 12;
		w1.Y = 8;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.image1 = new global::Gtk.Image();
		this.image1.WidthRequest = 150;
		this.image1.HeightRequest = 150;
		this.image1.Name = "image1";
		this.fixed1.Add(this.image1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.image1]));
		w2.X = 792;
		w2.Y = 8;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.WidthRequest = 700;
		this.GtkScrolledWindow.HeightRequest = 70;
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.WidthRequest = 700;
		this.textview1.HeightRequest = 50;
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w4.X = 15;
		w4.Y = 230;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textview2 = new global::Gtk.TextView();
		this.textview2.WidthRequest = 700;
		this.textview2.HeightRequest = 50;
		this.textview2.CanFocus = true;
		this.textview2.Name = "textview2";
		this.GtkScrolledWindow1.Add(this.textview2);
		this.fixed1.Add(this.GtkScrolledWindow1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow1]));
		w6.X = 15;
		w6.Y = 70;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Output_LBL = new global::Gtk.Label();
		this.Output_LBL.Name = "Output_LBL";
		this.Output_LBL.LabelProp = global::Mono.Unix.Catalog.GetString("OutPut calculation");
		this.fixed1.Add(this.Output_LBL);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.Output_LBL]));
		w7.X = 21;
		w7.Y = 199;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Input_Lbl = new global::Gtk.Label();
		this.Input_Lbl.Name = "Input_Lbl";
		this.Input_Lbl.LabelProp = global::Mono.Unix.Catalog.GetString("InPut calculation");
		this.fixed1.Add(this.Input_Lbl);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.Input_Lbl]));
		w8.X = 12;
		w8.Y = 42;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Exit_BTN = new global::Gtk.Button();
		this.Exit_BTN.WidthRequest = 100;
		this.Exit_BTN.HeightRequest = 25;
		this.Exit_BTN.CanFocus = true;
		this.Exit_BTN.Name = "Exit_BTN";
		this.Exit_BTN.UseUnderline = true;
		this.Exit_BTN.Label = global::Mono.Unix.Catalog.GetString("Exit");
		this.fixed1.Add(this.Exit_BTN);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.Exit_BTN]));
		w9.X = 841;
		w9.Y = 324;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Cypher_Calc_BTN = new global::Gtk.Button();
		this.Cypher_Calc_BTN.WidthRequest = 200;
		this.Cypher_Calc_BTN.HeightRequest = 50;
		this.Cypher_Calc_BTN.CanFocus = true;
		this.Cypher_Calc_BTN.Name = "Cypher_Calc_BTN";
		this.Cypher_Calc_BTN.UseUnderline = true;
		this.Cypher_Calc_BTN.Label = global::Mono.Unix.Catalog.GetString("Calc Cypher");
		this.fixed1.Add(this.Cypher_Calc_BTN);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.Cypher_Calc_BTN]));
		w10.X = 743;
		w10.Y = 237;
		this.GtkAlignment.Add(this.fixed1);
		this.frame1.Add(this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString("<b>AFFINE CIPHER CALC</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.Add(this.frame1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 961;
		this.DefaultHeight = 375;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.Exit_BTN.Clicked += new global::System.EventHandler(this.OnExitBTNClicked);
		this.Cypher_Calc_BTN.Clicked += new global::System.EventHandler(this.OnCypherCalcBTNClicked);
	}
}
