using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Entities;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Utlilities;
using System.IO;
using System.Text;
using Dapper;
namespace ApiShopp.Domain.Repository
{
    public class AuthRepository
    {
        public static LoginResponse Login(LoginRequest request)
        {
            LoginResponse oLoginResponse = new LoginResponse();
            var procedure = "EXECUTE USP_2023_VALIDAR_USUARIO_SHP @User, @Password";
            var values = new { User = request.username.ToUpper(), Password = request.password };

            using (var connection = BdConnection.getConnection())
            {

                try
                {
                    var result = connection.QueryFirstOrDefault<User>(procedure, values);

                    if (result == null)
                        return new LoginResponse
                        {
                            status = "1",
                            message = "Usuario y/o contraseña incorrecta."
                        };

                    //result.token = "";
                    result.boat = getLastAssignmentBoat(result.userCode, result.rolCode);
                    result.person = getPersonUser(result.userCode);
                    if (result.rolCode == 1 & result.boat == null)
                        return new LoginResponse
                        {
                            status = "2",
                            message = "El usuario no tiene embarcación asignada."
                        };
                    

                    return new LoginResponse
                    {
                        status = "0",
                        user = result,
                        token = "",
                        //token = GenerateToken(result.userCode.ToString()),
                        message = "Login exitoso."
                    };

                }
                catch (Exception ex)
                {
                    return oLoginResponse;
                }
               
            }

         
            }


        private static Boat getLastAssignmentBoat(int userCode, int userRol)
        {
            if (userRol != 1) return null;

            Boat oBoat = new Boat();
            var procedure = "EXECUTE CRVTY_GET_LAST_CHEF_ASSIGNMENT @UserCode";
            var parameters = new { UserCode = userCode };
            using (var connection = BdConnection.getConnection())
            {
                try
                {
                    return connection.QueryFirstOrDefault<Boat>(procedure, parameters);
                }
                catch (Exception ex)
                {
                    return oBoat;
                }

            }
        }

        private static Person getPersonUser(int userCode)
        {
            

            Person oPerson = new Person();
            var procedure = "EXECUTE USP_2023_LISTAR_PERSONAS_API @name,@dni ,@type ,@UserCode";
            var parameters = new { name="",dni="",type=3,UserCode = userCode };
            using (var connection = BdConnection.getConnection())
            {
                try
                {
                    var result= connection.QueryFirstOrDefault<Person>(procedure, parameters);
                    var typeDocuments = DataRepository.GetTypeDocument().ToList();

                    result.typeDocument = typeDocuments.Find(x => x.typeDocumentCode == result.typeDocumentCode)??
                        new TypeDocument
                        { 
                            typeDocumentCode=0,
                            typeDocumentName="",
                            createFor="",
                            enabled=false
                        };

                    return result;

                }
                catch (Exception ex)
                {
                    return oPerson;
                }

            }
        }






    }
}
