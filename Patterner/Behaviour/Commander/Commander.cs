
using Patterner.Behaviour.Commander;
using System;

public class Commander
{
	public static void Run()
	{
		Text file = new Text();
		file.text = "Bebbebebebbee";

		CopyCommand copy = new CopyCommand();
		PasteCommand paste = new PasteCommand();

		copy.Execute();
		paste.Execute();
	}
}
