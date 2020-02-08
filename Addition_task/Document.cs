namespace Addition_task
{
    class Document
    {
        Title _title;
        Body _body;
        Footer _footer;

        public Document(Title title, Body body, Footer footer)
        {
            _title = title;
            _body = body;
            _footer = footer;
        }

        public void Show()
        {
            _title.Show();
            _body.Show();
            _footer.Show();
        }
    }
}
