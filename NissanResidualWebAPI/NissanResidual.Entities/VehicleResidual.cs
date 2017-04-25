namespace NissanResidual.Entities
{
    public class VehicleResidual
    {
        public int VehicleResidualId
        {
            get;
            set;
        }
        public int VehicleId
        {
            get;
            set;
        }
        public int TransmissionId
        {
            get;
            set;
        }
        public int EngineId
        {
            get;
            set;
        }
        public int DriveTrainId
        {
            get;
            set;
        }
        public decimal MSRP
        {
            get;
            set;
        }
        public int AgeTermShift
        {
            get;
            set;
        }
    }
}
