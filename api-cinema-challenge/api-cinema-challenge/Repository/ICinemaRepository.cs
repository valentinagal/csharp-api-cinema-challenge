﻿using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface ICinemaRepository
    {
        IEnumerable<Customers> GetCustomers();
        bool AddCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(int id);

        IEnumerable<Movies> GetMovies();
        Movies AddMovie(Movies movie);
        bool UpdateMovie(Movies movie);
        bool DeleteMovie(int id);

        IEnumerable<Screenings> GetScreenings();
        bool AddScreening(Screenings screening);

        IEnumerable<Tickets> GetTickets();
        bool AddTicket(Tickets ticket);

    }
}