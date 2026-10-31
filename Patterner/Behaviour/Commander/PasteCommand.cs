class PasteCommand : AbstractCommand
{
    public override void Execute()
    {
        selectedText.text = Buffer;
    }
}