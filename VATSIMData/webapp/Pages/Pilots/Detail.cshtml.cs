using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VatsimLibrary.VatsimClientV1;
using VatsimLibrary.VatsimDb;

namespace VATSIMData.WebApp.Pages {
    public class PilotDetailModel : PageModel {
        private VatsimDbContext db;
        public string highestAltitude { get; set; }
       public string topSpeed { get; set; }
       public string farthestEast { get; set; }
       public string farthestSouth { get; set; }
        public VatsimClientPilotV1 Pilot { get; set; }
        public IEnumerable<VatsimClientPilotSnapshotV1> Positions { get; set; }
        public PilotDetailModel(VatsimDbContext db) {
            this.db = db;
        }

                    

        public async Task<IActionResult> OnGetAsync(string cid, string callsign, string timelogon) {
            Pilot = await db.Pilots.FindAsync(cid, callsign, timelogon);

            if(Pilot == null) {
                return RedirectToPage("NotFound");
            } 
            
            Positions = await db.Positions.Where(x => x.Callsign == (callsign) && x.TimeLogon == (timelogon)).ToListAsync();

            highestAltitude = Positions.Where(x => x.Callsign == (callsign) && x.TimeLogon == (timelogon)).Max(x => x.Altitude);
            topSpeed = Positions.Where(x => x.Callsign == (callsign) && x.TimeLogon == (timelogon)).Max(x => x.Groundspeed);
            var East = Positions.Select(x => x.Heading);
            farthestEast = Positions.Where(x => Convert.ToDouble(x.Longitude) > 0 && Convert.ToDouble(x.Longitude) < 180).Max(x => x.Longitude);
            farthestSouth = Positions.Where(x => Convert.ToDouble(x.Latitude) < 0 && Convert.ToDouble(x.Latitude) > -90).Max(x => x.Latitude);
            

            return Page();
        }     
               
    }

}