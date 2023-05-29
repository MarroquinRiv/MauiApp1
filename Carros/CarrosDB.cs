using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Carros;

namespace MauiApp1.Carros
{
    internal class CarrosDB
    {
        public readonly string cadenaConexion = "Data Source=c:\\tmp\\CarrosDB.db";
        private readonly SQLiteConnection conexion;

        public CarrosDB()
        {
            conexion = new SQLiteConnection(cadenaConexion);
        }

        //CREATE
        public void crearTablaCarros()
        {
            try
            {
                conexion.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Carros (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            marca TEXT,
            modelo TEXT,
            color TEXT,
            anio INTEGER,
            tipo TEXT,
            vmax INTEGER,
            vel INTEGER,
            a INTEGER,
            frena INTEGER,
            vrev INTEGER,
            vmaxrev INTEGER,
            peso INTEGER,
            puertas INTEGER,
            carrerasGanadas INTEGER,
            carroceria TEXT,
            produccion TEXT,
            garantia TEXT,
            cilindros INTEGER,
            subclase TEXT,
            potencia TEXT,
            motor TEXT,
            traccion TEXT,
            suspension TEXT,
            tecnologia TEXT,
            disenio TEXT,
            velocidades INTEGER
        )";

                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void insertarCarro(IVehiculo carro)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO Carros (marca, modelo, color, anio, tipo, vmax, vel, a, frena, vrev, " +
                    "vmaxrev, peso, puertas, carrerasGanadas, carroceria, produccion, garantia, cilindros, " +
                    "subclase, potencia, motor, traccion, suspension, tecnologia, disenio, velocidades) " +
                             $"VALUES ('{carro.marca}', '{carro.modelo}', '{carro.color}', {carro.anio}, " +
                             $"'{carro.tipo}', " +
                             $"{(carro is granTurismo ? $"'{(carro as granTurismo).peso}'" : "NULL")}, " +
                             $"{(carro is granTurismo ? $"'{(carro as granTurismo).puertas}'" : "NULL")}, " +
                             $"{(carro is granTurismo ? $"'{(carro as granTurismo).carrerasGanadas}'" : "NULL")}, " +
                             $"{(carro is hotHatch ? $"'{(carro as hotHatch).carroceria}'" : "NULL")}, " +
                             $"{(carro is hotHatch ? $"'{(carro as hotHatch).produccion}'" : "NULL")}, " +
                             $"{(carro is hotHatch ? $"'{(carro as hotHatch).garantia}'" : "NULL")}, " +
                             $"{(carro is muscleCar ? (carro as muscleCar).cilindros.ToString() : "NULL")}, " +
                             $"{(carro is muscleCar ? $"'{(carro as muscleCar).subclase}'" : "NULL")}, " +
                             $"{(carro is muscleCar ? $"'{(carro as muscleCar).potencia}'" : "NULL")}, " +
                             $"{(carro is roadster ? $"'{(carro as roadster).motor}'" : "NULL")}, " +
                             $"{(carro is roadster ? $"'{(carro as roadster).traccion}'" : "NULL")}, " +
                             $"{(carro is roadster ? $"'{(carro as roadster).suspension}'" : "NULL")}, " +
                             $"{(carro is superCar ? $"'{(carro as superCar).tecnologia}'" : "NULL")}, " +
                             $"{(carro is superCar ? $"'{(carro as superCar).disenio}'" : "NULL")}, " +
                             $"{(carro is superCar ? (carro as superCar).velocidades.ToString() : "NULL")})";

                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        //READ
        public void mostrarTodosLosCarros()
        {
            try
            {
                conexion.Open();
                string sql = "SELECT * FROM Carros";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string marca = reader["marca"].ToString();
                    string modelo = reader["modelo"].ToString();
                    string color = reader["color"].ToString();
                    int anio = Convert.ToInt32(reader["anio"]);
                    string tipo = reader["tipo"].ToString();
                    int vmax = Convert.ToInt32(reader["vmax"]);
                    int vel = Convert.ToInt32(reader["vel"]);
                    int a = Convert.ToInt32(reader["a"]);
                    int frena = Convert.ToInt32(reader["frena"]);
                    int vrev = Convert.ToInt32(reader["vrev"]);
                    int vmaxrev = Convert.ToInt32(reader["vmaxrev"]);
                    string duenio = reader["duenio"].ToString();

                    // Verificar el tipo de carro y mostrar la información correspondiente
                    Console.WriteLine($"ID: {id}");
                    Console.WriteLine($"Marca: {marca}");
                    Console.WriteLine($"Modelo: {modelo}");
                    Console.WriteLine($"Color: {color}");
                    Console.WriteLine($"Anio: {anio}");
                    Console.WriteLine($"Tipo: {tipo}");
                    Console.WriteLine($"Velocidad Maxima: {vmax}");
                    Console.WriteLine($"Velocidad: {vel}");
                    Console.WriteLine($"Aceleracion: {a}");
                    Console.WriteLine($"Frenado: {frena}");
                    Console.WriteLine($"Velocidad Reversa: {vrev}");
                    Console.WriteLine($"Velocidad Maxima Reversa: {vmaxrev}");
                    Console.WriteLine($"Duenio: {duenio}");

                    if (reader["carroceria"] != DBNull.Value && reader["produccion"] != DBNull.Value && reader["garantia"] != DBNull.Value)
                    {
                        string carroceria = reader["carroceria"].ToString();
                        string produccion = reader["produccion"].ToString();
                        string garantia = reader["garantia"].ToString();
                        Console.WriteLine($"Carroceria: {carroceria}");
                        Console.WriteLine($"Produccion: {produccion}");
                        Console.WriteLine($"Garantia: {garantia}");
                    }
                    else if (reader["cilindros"] != DBNull.Value && reader["subclase"] != DBNull.Value && reader["potencia"] != DBNull.Value)
                    {
                        int cilindros = Convert.ToInt32(reader["cilindros"]);
                        string subclase = reader["subclase"].ToString();
                        string potencia = reader["potencia"].ToString();
                        Console.WriteLine($"Cilindros: {cilindros}");
                        Console.WriteLine($"Subclase: {subclase}");
                        Console.WriteLine($"Potencia: {potencia}");
                    }
                    else if (reader["motor"] != DBNull.Value && reader["traccion"] != DBNull.Value && reader["suspension"] != DBNull.Value)
                    {
                        string motor = reader["motor"].ToString();
                        string traccion = reader["traccion"].ToString();
                        string suspension = reader["suspension"].ToString();
                        Console.WriteLine($"Motor: {motor}");
                        Console.WriteLine($"Traccion: {traccion}");
                        Console.WriteLine($"Suspension: {suspension}");
                    }
                    else if (reader["tecnologia"] != DBNull.Value && reader["disenio"] != DBNull.Value && reader["velocidades"] != DBNull.Value)
                    {
                        string tecnologia = reader["tecnologia"].ToString();
                        string disenio = reader["disenio"].ToString();
                        int velocidades = Convert.ToInt32(reader["velocidades"]);
                        Console.WriteLine($"Tecnologia: {tecnologia}");
                        Console.WriteLine($"Disenio: {disenio}");
                        Console.WriteLine($"Velocidades: {velocidades}");
                    }

                    Console.WriteLine("-----------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        //UPDATE
        public void asignarDuenio(int id, string duenio)
        {
            try
            {
                conexion.Open();
                string sql = $"UPDATE Carros SET duenio = '{duenio}' WHERE id = {id}";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }


        //DELETE
        public void eliminarCarro(int id)
        {
            try
            {
                conexion.Open();
                string sql = $"DELETE FROM Carros WHERE id = {id}";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
