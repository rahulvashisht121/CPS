using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using DataAccess;
namespace BusinessLogic
{
    public class MngManufacturerBL
    {
        /// <summary>
        /// fetch all collection by default 
        /// or gets data for particular manufacture
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public static ManufacturerList Get_CollectionManufacture(int Id)
        {
            try
            {
                return ManufacturerDA.GetManufactureList(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
        /// <summary>
        /// to update a display Order
        /// </summary>
        /// <param name="ManfId"></param>
        /// <param name="DpOrder"></param>

        public static int UpdateDisplayOrder(string ManfId, string DpOrder)
        {
            try
            {
                return  ManufacturerDA.UpdateDisplayOrder(ManfId, DpOrder);
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// to update a new Manufacture
        /// </summary>
        /// <param name="ManfId"></param>
        /// <param name="DpOrder"></param>
        public static int AddNew_UpdateManufacture(ManufacturerBO man)
        {
            try
            {
                return ManufacturerDA.Insert_Update_Manufacture(man);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// to delete a manufacturer
        /// </summary>
        /// <param name="manid"></param>

        public static void DeleteManufacture(int manid)
        {
            try
            {
                 ManufacturerDA.DeleteMaufacture(manid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
