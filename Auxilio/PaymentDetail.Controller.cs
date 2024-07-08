using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly PaymentDetailContext Newcontext;

        public PaymentDetailController(PaymentDetailContext context)
        {
            Newcontext = context;
        }

        // GET: api/PaymentDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetail>>> GetPaymentDetails()
        {
          if (Newcontext.PaymentDetails == null)
          {
              return NotFound();
          }
            return await Newcontext.PaymentDetails.ToListAsync();
        }

        // GET: api/PaymentDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetail>> GetPaymentDetail(int id)
        {
          if (Newcontext.PaymentDetails == null)
          {
              return NotFound();
          }
            var paymentDetail = await Newcontext.PaymentDetails.FindAsync(id);

            if (paymentDetail == null)
            {
                return NotFound();
            }

            return paymentDetail;
        }

        // PUT: api/PaymentDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetail(int id, PaymentDetail paymentDetail)
        {
            if (id != paymentDetail.PaymentDetailId)
            {
                return BadRequest();
            }

            Newcontext.Entry(paymentDetail).State = EntityState.Modified;

            try
            {
                await Newcontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(await Newcontext.PaymentDetails.ToListAsync());
        }

        // POST: api/PaymentDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentDetail>> PostPaymentDetail(PaymentDetail paymentDetail)
        {
          if (Newcontext.PaymentDetails == null)
          {
              return Problem("Entity set 'PaymentDetailContext.PaymentDetails'  is null.");
          }
            Newcontext.PaymentDetails.Add(paymentDetail);
            await Newcontext.SaveChangesAsync();

            return Ok(await Newcontext.PaymentDetails.ToListAsync());
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetail(int id)
        {
            if (Newcontext.PaymentDetails == null)
            {
                return NotFound();
            }
            var paymentDetail = await Newcontext.PaymentDetails.FindAsync(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            Newcontext.PaymentDetails.Remove(paymentDetail);
            await Newcontext.SaveChangesAsync();

            return Ok(await Newcontext.PaymentDetails.ToListAsync());
        }

        private bool PaymentDetailExists(int id)
        {
            return (Newcontext.PaymentDetails?.Any(e => e.PaymentDetailId == id)).GetValueOrDefault();
        }
    }
}