﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_pemvis
{
    public static class DB
    {
        public static string dbServer = "localhost";
        public static string dbUser = "root";
        public static string dbName = "project-pemvis";
        public static string dbPass = "";

        public static string ConnStr => $"server={dbServer};user={dbUser};database={dbName};password={dbPass};";
    }
}
