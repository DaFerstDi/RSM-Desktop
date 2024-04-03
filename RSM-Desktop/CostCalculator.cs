using RSM_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM_Desktop
{
    internal class CostCalculator
    {
        public static long Calculate(Command command)
        {
            long summ = command.money.get_value();
            double portsK;
            portsK = 1.0 + 0.2 * (command.ports_dv.get_value() + command.ports_okt.get_value() + command.ports_sev.get_value());
            summ += Convert.ToInt64((1 + 0.2 * command.coal.get_value()) * command.coal.get_value() * 5500000);
            summ += Convert.ToInt64((1 + 0.2 * command.oil.get_value()) * command.oil.get_value() * 2500000);
            summ += Convert.ToInt64((1 + 0.2 * command.coke.get_value()) * command.coke.get_value() * 1000000);
            summ += Convert.ToInt64((1 + 0.2 * command.bl_met.get_value()) * command.bl_met.get_value() * 4500000);
            summ += Convert.ToInt64((1 + 0.2 * command.iron.get_value()) * command.iron.get_value() * 700000);
            summ += Convert.ToInt64((1 + 0.2 * command.build.get_value()) * command.build.get_value() * 500000);
            summ += Convert.ToInt64((1 + 0.2 * command.cement.get_value()) * command.cement.get_value() * 400000);
            summ += Convert.ToInt64((1 + 0.2 * command.forest.get_value()) * command.forest.get_value() * 600000);
            summ += Convert.ToInt64((1 + 0.2 * command.chemical.get_value()) * command.chemical.get_value() * 5000000);
            summ += Convert.ToInt64((1 + 0.2 * command.seed.get_value()) * command.seed.get_value() * 2000000);
            summ += Convert.ToInt64((1 + 0.2 * command.container.get_value()) * command.container.get_value() * 3000000);
            summ += Convert.ToInt64(portsK * command.ports_dv.get_value() * 5000000); // Дальневосточные
            summ += Convert.ToInt64(portsK * command.ports_okt.get_value() * 4000000); // Октябрьские
            summ += Convert.ToInt64(portsK * command.ports_sev.get_value() * 1000000); // Северо-Кавказские


            if (command.is_maxPoints())
            {
                summ += Convert.ToInt64(command.points.get_value() * 100000L * 1.5);
            }
            else
            {
                summ += command.points.get_value() * 100000L;
            }



            if (command.is_maxCarriage())
            {
                summ += Convert.ToInt64(command.cis.get_value() / 10 * 1600000L * 1.2);
                summ += Convert.ToInt64(command.pv.get_value() / 10 * 1200000L * 1.2);
                summ += Convert.ToInt64(command.kr.get_value() / 10 * 1400000L * 1.2);
                summ += Convert.ToInt64(command.pl.get_value() / 10 * 1000000L * 1.2);
            }
            else
            {
                summ += command.cis.get_value() / 10 * 1600000L;
                summ += command.pv.get_value() / 10 * 1200000L;
                summ += command.kr.get_value() / 10 * 1400000L;
                summ += command.pl.get_value() / 10 * 1000000L;
            }


            return summ;
        }
    }
}
