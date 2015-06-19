using TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.FileLayouts.AbstractClasses.Tiger2010.StateFiles;

namespace TAMU.GeoInnovation.Applications.Census.ReferenceDataImporter.PostgreSQL.FileLayouts.Implementations.Tiger2010.StateFiles
{
    public class CensusBlock2010File : AbstractTiger2010ShapefileStateFileLayout
    {
        

        public CensusBlock2010File(string stateName)
            : base(stateName)
        {

            ExcludeColumns = new string[] 
            { 
                "uniqueId",
            };

            FileName = "tabblock10.zip";

            SQLCreateTable += "CREATE TABLE " + OutputTableName + " (";
            SQLCreateTable += "uniqueId SERIAL,";
            SQLCreateTable += "stateFp10 Varchar DEFAULT NULL,";
            SQLCreateTable += "countyFp10 Varchar DEFAULT NULL,";
            SQLCreateTable += "TractCe10 Varchar DEFAULT NULL,";
            SQLCreateTable += "BlockCe10 Varchar DEFAULT NULL,";
            SQLCreateTable += "GeoId10 Varchar DEFAULT NULL,";
            SQLCreateTable += "Name10 Varchar DEFAULT NULL,";
            SQLCreateTable += "Mtfcc10 Varchar DEFAULT NULL,";
            SQLCreateTable += "UR10 Varchar DEFAULT NULL,";
            SQLCreateTable += "UAce10 Varchar DEFAULT NULL,";
            SQLCreateTable += "FuncStat10 Varchar DEFAULT NULL,";
            SQLCreateTable += "aLand10 Varchar DEFAULT NULL,";
            SQLCreateTable += "aWater10 Varchar DEFAULT NULL,";
            SQLCreateTable += "intPtLat10 Varchar DEFAULT NULL,";
            SQLCreateTable += "intPtLon10 Varchar DEFAULT NULL,";
            SQLCreateTable += "shapeType Varchar, ";
            SQLCreateTable += "shapeGeog geography,";
            SQLCreateTable += "shapeGeom geometry,";
            SQLCreateTable += "PRIMARY KEY  (uniqueId)";
            SQLCreateTable += ");";

        }
    }
}
