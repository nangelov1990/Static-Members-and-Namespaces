namespace HTML_Dispatcher
{
    using System;
    using HTML_Dispatcher.Engine;
    public static class Tester
    {
        static void Main(string[] args)
        {
            var div = new ElementBuilder("div");

            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            string image = HTMLDispatcher.CreateImage("about:blank", null, "alt", "title").ToString();
            string imageWithClass = HTMLDispatcher.CreateImage("about:blank", "image", "alt", "title").ToString();
            string emptyUrl = HTMLDispatcher.CreateUrl("about:blank", null, "title", "text").ToString();
            string contentUrl = HTMLDispatcher.CreateUrl("about:blank", "url", "title", "text", "<p>Hello</p>").ToString();
            string emptyInput = HTMLDispatcher.CreateInput(HTMLDispatcher.InputType.button, null, "name", "value").ToString();
            string contentInput = HTMLDispatcher.CreateInput(HTMLDispatcher.InputType.button, "input", "name", "value", "BUTTON").ToString();

            var elements = new string[]
            {
                image,
                imageWithClass,
                emptyUrl,
                contentUrl,
                emptyInput,
                contentInput
            };

            Console.WriteLine(div * 2);

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
