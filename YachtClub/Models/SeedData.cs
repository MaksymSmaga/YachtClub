using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace YachtClub.Models
{
    public static class SeedData
    {
        // The static EnsurePopulated method receives an IApplicationBuilder argument, which is the interface
        // used in the Configure method of the Startup class to register middleware components to handle HTTP
        // requests, and this is where I will ensure that the database has content.

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Yachts.Any())
            {
                context.Yachts.AddRange(


              new Yacht { Name = "2021 Spirit Yachts 65DH", Description = "A captivatingly good-looking Spirit 65DH with a deck saloon that is in perfect proportion", Photo = "/images/2021SpiritYachts65DH.jpg", Category = "Cruiser", Price = 2779727.0m },
              new Yacht { Name = "2000 Fairline Targa 30", Description = "Mooring option in one of the most luxurious marinas in Mallorca – available by separate negotiation", Photo = "/images/2000FairlineTarga30.jpg", Category = "Cruiser", Price = 90242.0m },
              new Yacht { Name = "2007 Nautor Swan Swan 75", Description = "The Nautor Swan 75 FD is the true expression of luxury lifestyle", Photo = "/images/2007NautorSwanSwan75.jpg", Category = "Cruiser", Price = 2532476m },
              new Yacht { Name = "2018 Jeanneau Leader 30", Description = "2018 build, 2019 model - Twin Yamaha F200 GTX petrol outboard engines (2 x 197hp)", Photo = "/images/2018JeanneauLeader30.jpg", Category = "Cruiser", Price = 172828.0m },
              new Yacht { Name = "2018 Bavaria C50 Style", Description = "El diseñador Mauricio Cossutti ha creado un barco excepcional", Photo = "/images/2018BavariaC50Style.jpg", Category = "Cruiser", Price = 432442.0m },

              new Yacht { Name = "2016 Prestige 680", Description = "Available for immediate delivery. 2016 Prestige 680 four cabin version with Grey Oak interior", Photo = "/images/2016Prestige680.jpg", Category = "Motor", Price = 1572042.0m },
              new Yacht { Name = "2006 Sunseeker Predator 62", Description = "Remote control - anchor, thrusters, motors, platform, generator, watermaker", Photo = "/images/2006SunseekerPredator62.jpg", Category = "Motor", Price = 578393.0m },
              new Yacht { Name = "2023 Sailboat Project Sonata", Description = "We are delighted to announce new sales central agency PROJECT SONATA", Photo = "/images/2023SailboatProjectSonata.jpg", Category = "Motor", Price = 0.0m },
              new Yacht { Name = "2013 Custom Balk Shipyard Schooner MSV", Description = "MSV is a unique sailing yacht that offers the aesthetics of a classic ", Photo = "/images/2013CustomBalkShipyardSchoonerMSV.jpg", Category = "Motor", Price = 15548837.0m },

              new Yacht { Name = "2010 Custom Van der Graff gaff schooner ATLANTIC", Description = "Three-masted Van der Graaf gaff schooner, designed by William Gardner", Photo = "/images/2010CustomVanderGraffgaffschoonerATLANTIC.jpg", Category = "Schooner", Price = 0.0m },
              new Yacht { Name = "2010 Custom Van Der Graaf BV Schooner ATLANTIC", Description = "The current ATLANTIC is the replica of legendary ATLANTIC", Photo = "/images/2010CustomVanDerGraafBVSchoonerATLANTIC.jpg", Category = "Schooner", Price = 0.0m },
              new Yacht { Name = "2010 Custom Van Der Graaf BV ATLANTIC", Description = "William Gardner designed replica of the original Atlantic built in 1903", Photo = "/images/2010CustomVanDerGraafBVATLANTIC.jpg", Category = "Schooner", Price = 0.0m },
              new Yacht { Name = "2011 Factoria Naval de Marin Custom Built Schooner Germania Nova", Description = "The 59.80m luxury sailing yacht GERMANIA NOVA", Photo = "/images/2011FactoriaNavaldeMarinCustomBuiltSchoonerGermaniaNova.jpg", Category = "Schooner", Price = 5220941.0m },

              new Yacht { Name = "2022 Greenline 68 OceanClass", Description = "This wonderful new build yacht will be launched at our test centre in Pororoz (Slovenia) in June 2022", Photo = "/images/2022Greenline68OceanClass.jpg", Category = "Others", Price = 2521924.0m },
              new Yacht { Name = "2010 Custom Van der Graaf ATLANTIC", Description = "The three mast Schooner ATLANTIC, is a magnificent replica of the 1903 William Gardener", Photo = "/images/2010CustomVanderGraafATLANTIC.jpg", Category = "Others", Price = 0.0m },
              new Yacht { Name = "2017 Royal Huisman Dubois Mega Sloop NGONI", Description = "Lloyds 5 Year class survey just completed (April22) - Ngoni presents like a new yacht throughout", Photo = "/images/2017RoyalHuismanDuboisMegaSloopNGONI.jpg", Category = "Others", Price = 47463097.0m },
              new Yacht { Name = "2014 Alloy Flybridge MONDANGO 3", Description = "The flybridge ketch MONDANGO 3 has an aluminium hull and superstructure constructedt", Photo = "/images/2014AlloyFlybridgeMONDANGO3.jpg", Category = "Others", Price = 36914107.0m },

              new Yacht { Name = "2023 Custom Hybrid-Alt Electric DynaRigTri Aegir 2.0", Description = "This New Design Concept by Legendary Yacht Designer Group", Photo = "/images/2023CustomHybrid-AltElectricDynaRigTriAegir2.0.jpg", Category = "Cata/Trimaran", Price = 0.0m },
              new Yacht { Name = "2022 Concept SEA VOYAGER 223 SEA VOYAGER 223", Description = "The 223-foot (70m) luxury catamaran SEA VOYAGER 223", Photo = "/images/2022ConceptSEAVOYAGER223SEAVOYAGER223.jpg", Category = "Cata/Trimaran", Price = 0.0m }
              );

                context.SaveChanges();
            }
        }
    }
}


