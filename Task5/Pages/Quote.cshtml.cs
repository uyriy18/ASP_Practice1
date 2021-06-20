using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Task5.Pages
{
    public class QuoteModel : PageModel
    {
        public string Message { get; set; }
        private string[] quotes =
        {
            "The greatest glory in living lies not in never falling, but in rising every time we fall. -Nelson Mandela",
            "The way to get started is to quit talking and begin doing. -Walt Disney",
            "Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking. -Steve Jobs",
            "If life were predictable it would cease to be life, and be without flavor. -Eleanor Roosevelt",
            "If you look at what you have in life, you'll always have more. If you look at what you don't have in life, you'll never have enough. -Oprah Winfrey",
            "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success. -James Cameron",
            "Life is what happens when you're busy making other plans. -John Lennon"
        };

        private string choseQuote()
        {
            var rand = new Random();
            int i = rand.Next(0,6);
            return quotes[i];
        }
        public void OnGet()
        {
            Message = choseQuote();
        }
    }
}
