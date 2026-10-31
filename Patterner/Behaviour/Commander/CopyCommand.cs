using System;

namespace Patterner.Behaviour.Commander
{
    internal class CopyCommand: AbstractCommand
    {
        public override void Execute()
        {
            Buffer = selectedText.text;
            Console.WriteLine($"COPIED {Buffer}");
        }       
    }
}
