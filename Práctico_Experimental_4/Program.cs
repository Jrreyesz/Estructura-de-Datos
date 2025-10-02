Dictionary<string, int> vuelos = new Dictionary<string, int>
{
    {"Iberia", 950},
    {"Brittish Airways", 150},
    {"Air France", 120},
    {"Lufthansa", 135},
    {"KLM", 115},
    {"American Airlines", 1100},
    {"United Airlines", 1050},
    {"Delta", 1080},
    {"Air Canada", 990},
    {"Alitalia", 105},
    {"Swiss", 160},
    {"Turkish Airlines", 480},
    {"SAS", 190},
    {"Aer Lingus", 185},
    {"TAP Air Portugal", 95},
    {"Aeroflot", 550},
    {"Austrian Airlines", 145},
    {"LATAM", 1150},
    {"Aeroméxico", 890},
    {"Avianca", 980}
};

foreach (int precio in vuelos.Values)
{
    Insertar(precio);
}

