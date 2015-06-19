using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.StateFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.PostgreSQL.FileLayouts.Implementations.Tiger2010.StateFiles
{
    public class CensusTract2010File : AbstractTiger2010ShapefileStateFileLayout
    {

       

        public CensusTract2010File(string stateName)
            : base(stateName)
        {

            ExcludeColumns = new string[] 
            { 
                "uniqueId"
            };


            FileName = "tract10.zip";

            SQLCreateTable += "CREATE TABLE " + OutputTableName + " (";
            SQLCreateTable += "uniqueId SERIAL,";
            SQLCreateTable += "stateFp10 Varchar DEFAULT NULL,";
            SQLCreateTable += "countyFp10 Varchar DEFAULT NULL,";
            SQLCreateTable += "TractCe10 Varchar DEFAULT NULL,";
            SQLCreateTable += "GEOID10 Varchar DEFAULT NULL,";
            SQLCreateTable += "Name10 Varchar DEFAULT NULL,";
            SQLCreateTable += "NameLsad10 Varchar DEFAULT NULL,";
            SQLCreateTable += "Mtfcc10 Varchar DEFAULT NULL,";
            SQLCreateTable += "FuncStat10 Varchar DEFAULT NULL,";
             SQLCreateTable += "ALAND10  Varchar DEFAULT NULL,";
            SQLCreateTable += "AWATER10 Varchar DEFAULT NULL,";
            SQLCreateTable += "INTPTLAT10  Varchar DEFAULT NULL,";
            SQLCreateTable += "INTPTLON10 Varchar DEFAULT NULL,";
            SQLCreateTable += "shapeType Varchar, ";
            SQLCreateTable += "shapeGeog geography,";
            SQLCreateTable += "shapeGeom geometry,";
            SQLCreateTable += "PRIMARY KEY  (uniqueId)";
            SQLCreateTable += ");";

        }

    }
}

 