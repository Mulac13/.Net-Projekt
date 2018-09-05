# .Net-Projekt
# ImportExcel aplikacija
Aplikacija ImportExcel je Windows Forms aplikacija koja je namijenjena čitanju podataka iz Excel tablice i zapisivanjem tih podataka u bazu aplikacije.
Aplikacija koristi EntityFramework kao alat za rad s bazom podataka. Aplikacija koristi EPPLus biblioteku za čitanje Excel datoteka.
Prilikom pokretanja aplikacije korisniku se prikazuje sučelje s uputama za učitavanje Excel datoteke (definicija strukture Excel datoteke koja se očekuje u aplikaciji), 
gumb za pokretanje dijaloškog okvira kojim se bira Excel datoteka za učitavanje, te je omogućeno sortiranje podataka po željenim parametrima.
Korisnik ima mogućnost pregleda postojećih unosa u bazi (proizvoda) kroz DataGridView.
Čitanje Excel datoteke je zamišljeno na način da se krene čitati prvi red datoteke, te se ovisno o redoslijedu stupaca pojedini podatak veže uz
entity Proizvoda u bazi. Za svaki redak se kreira novi unos u bazi te se isti zapisuje.

