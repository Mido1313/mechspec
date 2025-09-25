using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Conektion
{
    class Conect
    {
        private string server = "localhost";
        private string database = "DATABASE.db";

        private int year = 0;
        private string fraction = "";
        private string technologyniveau = "";
        private string technologyavailability = "";



        // Konstruktor
        public Conect()
        {
            // Standard-Konstruktor
            // Stellt die Verbindung zur Datenbank her
        }



        // Methoden

        // Fraction
        public void SetFraction(string fraction)
        {
            this.fraction = fraction;
        }
        public string GetFraction()
        {
            return fraction;
        }
        /// <summary>
        /// Gets all factions based on year as from the database as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// Fraction (string)
        /// </returns>
        public DataTable GetFractions()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Year
        public void SetYear(int year)
        {
            if (year < 2000 || year > 4000 || year == 0)
            {
                throw new ArgumentOutOfRangeException("Year must be between 2000 and 4000 or 0.");
            }
            this.year = year;
        }
        public int GetYear()
        {
            return year;
        }

        // technologyniveau
        public void Settechnologyniveau(string technologyniveau)
        {
            if (technologyniveau == "")
            {
                throw new ArgumentException("technologyniveau cannot be empty.");
            }
            DataTable validNiveaus = GetTechnologyNiveaus();

            if (!validNiveaus.AsEnumerable().Any(row => row.Field<string>("technologyniveau") == technologyniveau))
            {
                throw new ArgumentException("Invalid technologyniveau.");
            }

            this.technologyniveau = technologyniveau;
        }
        public string Gettechnologyniveau()
        {
            return technologyniveau;
        }
        /// <summary>
        /// Gets all available technology niveaus from the database as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// technologyniveau (string)
        /// </returns>
        public DataTable GetTechnologyNiveaus()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Technologievverfügbarkeit
        public void SetTechnologyAvailability(string technologyavailability)
        {
            if (technologyavailability == "")
            {
                throw new ArgumentException("technologyavailability cannot be empty.");
            }
            DataTable validAvailabilitys = GetTechnologyAvailabilityen();
            if (!validAvailabilitys.AsEnumerable().Any(row => row.Field<string>("Technologieverfügbarkeit") == technologyavailability))
            {
                throw new ArgumentException("Invalid technologyavailability.");
            }
            this.technologyavailability = technologyavailability;
        }
        public string GetTechnologyAvailability()
        {
            return technologyavailability;
        }
        /// <summary>
        /// Gets all technology from the database as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="DataTable"/> contains the columns:
        /// technologyverfügbarkeit (string)
        /// </returns>
        public DataTable GetTechnologyAvailabilityen()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }


        // InternealeStruktur
        /// <summary>
        /// Gets all available internal structures based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableInternealStruktur()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Slots
        /// <summary>
        /// Gets the available slots based on tonnage, technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// torso (int), arm (int), leg (int)
        /// </returns>
        public DataTable GetAvailableSlots(int tonnage)
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Internal Structure Integrity
        /// <summary>
        /// Gets the internal structure integrity based on tonnage as a <see cref="DataTable"/>.
        /// </summary>
        /// <param name="tonnage"></param>
        /// <returns>
        /// center_torso (int), left_right_torso (int), arm (int), leg (int)
        /// </returns>
        public DataTable GetAvailableInternalStructureIntegrity(int tonnage)
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Musculature
        /// <summary>
        /// Gets all available musculature based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableMusculature()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Activator
        /// <summary>
        /// Gets all available activators based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableActivator()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Gyroscope
        /// <summary>
        /// Gets all available gyroscopes based on factions, year, tonage , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// the <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableGyroscope()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Reactor
        /// <summary>
        /// Gets all available reactors based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableReactor()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Reactor weight
        /// <summary>
        /// Gets the specific reactor weight based on reactorwert and reacktortype as a <see cref="DataTable"/>.
        /// </summary>
        /// <param name="reacktorwert"></param>
        /// <param name="reacktortype"></param>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// weight (int)
        /// </returns>
        public DataTable GetAvailableReactorWeight(int reacktorwert, string reacktortype)
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Special Movement
        /// <summary>
        /// Gets all available special movment based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableSpecialMovement()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Head Size
        /// <summary>
        /// Gets all available head sizes based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableHeadSize()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Cockpit System
        /// <summary>
        /// Gets all available cockpit systems based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), available_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableCockpitSystem()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Sensors
        /// <summary>
        /// Gets all available sensors based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableSensors()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Armor
        /// <summary>
        /// Gets all available armor based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableArmor()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Heat Sink
        /// <summary>
        /// Gets all available heat sinks based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// type (string), cost (int), weight (int), needed_slotz (int), specialRules (string)
        /// </returns>
        public DataTable GetAvailableHeatSink()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // Equipment
        /// <summary>
        /// Gets all available equipment based on factions, year , technology niveaus and technology Availability as a <see cref="DataTable"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="DataTable"/> contains the columns:
        /// ID (string), type (string), cost (int), weight (int), needed_slotz (int), range (string), damage (string), heat (int),
        /// ammo_per_ton (string), ammo_cost (int), special_ammo_available (string), attack_value_ammo (int), defense_value_ammo (int),
        /// aim_assist_computer (string), hit_probability_modifier (int), aim_assist_computer_value (int),
        /// attack_value (int), defense_value (int), attack_type (string), specialRules (string)
        /// </returns>
        public DataTable GetAvailableEquipment()
        {
            string sql = $"SELECT * FROM *;";
            return QueryAsDataTable(sql);
        }

        // single Equipment by ID
        /// <summary>
        /// Gets a single equipment by its ID as a <see cref="DataTable"/>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// returns all data about the equipment
        /// </returns>
        public DataTable GetSingleEquipmentByID(int id)
        {
            string sql = $"SELECT * FROM * WHERE id = {id};";
            return QueryAsDataTable(sql);
        }








        /// <summary>
        /// Aufruf einer SQL-Abfrage, die eine Ergebnismenge zurückgibt, als DataTable.
        /// </summary>
        private static DataTable QueryAsDataTable(string sql) // string cs, , params SqliteParameter[] args)
        {
            // using var con = new SqliteConnection(cs);
            // using var cmd = new SqliteCommand(sql, con);
            // if (args is { Length: > 0 }) cmd.Parameters.AddRange(args);
            // using var da = new SqliteDataAdapter(cmd);
            var table = new DataTable();
            // da.Fill(table);
            return table;
        }
    }
}
