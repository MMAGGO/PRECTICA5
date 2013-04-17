using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnSumarClicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (this.Numero1.Text);
		int num2 = int.Parse (this.Numero2.Text);
	
		int Sumar = num1 + num2;


		this.Resultado.Text = Sumar.ToString ();

	}

	protected void OnRestarClicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (this.Numero1.Text);
		int num2 = int.Parse (this.Numero2.Text);
		
		int Sumar = num1 - num2;
		
		
		this.Resultado.Text = Sumar.ToString ();
	}

	protected void OnDividirClicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (this.Numero1.Text);
		int num2 = int.Parse (this.Numero2.Text);
		
		int Sumar = num1 / num2;
		
		
		this.Resultado.Text = Sumar.ToString ();
	}

	protected void OnMultiplicarClicked (object sender, EventArgs e)
	{
		int num1 = int.Parse (this.Numero1.Text);
		int num2 = int.Parse (this.Numero2.Text);
		
		int Sumar = num1 * num2;
		
		
		this.Resultado.Text = Sumar.ToString ();
	}
}
