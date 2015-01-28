namespace HTML_Dispatcher.Engine
{
    public static class HTMLDispatcher
    {
        public enum InputType
        {
            button,
            checkbox,
            color,
            date,
            datetime,
            datetimelocal,
            email,
            fileupload,
            hidden,
            image,
            month,
            number,
            password,
            range,
            radio,
            reset,
            search,
            submit,
            text,
            time,
            url,
            week

        };

        public static ElementBuilder CreateImage(string imageSource, string imgClass = null, string alternativeText = null, string titleText = null)
        {
            var img = new ElementBuilder("img");

            img.AddAttribute("src", imageSource);
            
            if (!string.IsNullOrEmpty(imgClass))
            {
                img.AddAttribute("class", imgClass);
            }

            if (!string.IsNullOrEmpty(alternativeText))
            {
                img.AddAttribute("alt", alternativeText);
            }

            if (!string.IsNullOrEmpty(titleText))
            {
                img.AddAttribute("title", titleText);
            }

            return img;
        }

        public static ElementBuilder CreateUrl(string urlSource, string urlClass = null, string titleText = null, string urlText = null, string content = null)
        {
            var htmlUrl = new ElementBuilder("a");

            htmlUrl.AddAttribute("href", urlSource);

            if (!string.IsNullOrEmpty(urlClass))
            {
                htmlUrl.AddAttribute("class", urlClass);
            }

            if (!string.IsNullOrEmpty(titleText))
            {
                htmlUrl.AddAttribute("title", titleText);
            }

            if (!string.IsNullOrEmpty(urlText))
            {
                htmlUrl.AddAttribute("text", urlText);
            }

            if (!string.IsNullOrEmpty(content))
            {
                htmlUrl.AddContent(content);
            }

            return htmlUrl;
        }

        public static ElementBuilder CreateInput(InputType inputType, string inputClass = null, string name = null, string value = null, string content = null)
        {
            var input = new ElementBuilder("input");

            input.AddAttribute("type", inputType.ToString());

            if (!string.IsNullOrEmpty(inputClass))
            {
                input.AddAttribute("class", inputClass);
            }

            if (!string.IsNullOrEmpty(name))
            {
                input.AddAttribute("name", name);
            }

            if (!string.IsNullOrEmpty(value))
            {
                input.AddAttribute("value", value);
            }

            if (!string.IsNullOrEmpty(content))
            {
                input.AddContent(content);
            }
            return input;
        }
    }
}
