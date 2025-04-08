using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    internal abstract class SystemError
    {
        public abstract string ErrorMessage();
    }

    internal class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Engine failure: Control engine status";
        }
    }

    internal class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Brake failure: Vehicle is unsafe to drive";
        }
    }

    internal class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission failure: Repair required";
        }
    }
}
