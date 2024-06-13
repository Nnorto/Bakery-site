using System;
using System.Threading.Tasks;
using Bakery.Data;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
namespace Bakery.Pages
{
    public class OrderModel : PageModel
    {
        private BakeryContext db;
        public OrderModel(BakeryContext db) => this.db = db;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public Product Product { get; set; }
        [BindProperty, EmailAddress, Required, Display(Name = "Ваш адрес электронной почты")]
        public string OrderEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Пожалуйста, укажите адрес доставки"), Display(Name = "Адрес доставки")]
        public string OrderShipping { get; set; }

        [BindProperty, Display(Name = "Количество")]
        public int OrderQuantity { get; set; } = 1;

        public async Task OnGetAsync() => Product = await db.Products.FindAsync(Id);

        public async Task<IActionResult> OnPostAsync()
        {
            Product = await db.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                var body = $@"<p>Спасибо, ваш заказ на {OrderQuantity} единиц(ы) товара {Product.Name} принят!</p>
                    <p>Ваш адрес: <br/>{OrderShipping.Replace("\n", "<br/>")}</p>
                    Ваша итоговая сумма: ₽{Product.Price * OrderQuantity}.<br/>
                    Мы свяжемся с вами, если у нас возникнут вопросы по вашему заказу. Спасибо!<br/>";
                using (var smtp = new SmtpClient())
                {
                    smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smtp.PickupDirectoryLocation = @"Z:\Desktop\Bakery\Bakery\mailpickup\";
                    var message = new MailMessage();
                    message.To.Add(OrderEmail);
                    message.Subject = "Bakery Brews - Новый заказ";
                    message.Body = body;
                    message.IsBodyHtml = true;
                    message.From = new MailAddress("sales@bakerybrews.com");
                    await smtp.SendMailAsync(message);
                }
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}