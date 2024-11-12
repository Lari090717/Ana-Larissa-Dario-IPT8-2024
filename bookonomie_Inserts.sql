-- Zuerst die Autoren in die Tabelle 'Author' einfügen
INSERT INTO Author (AuthorName) VALUES ('Patrick Rothfuss');
INSERT INTO Author (AuthorName) VALUES ('George R.R. Martin');
INSERT INTO Author (AuthorName) VALUES ('Markus Heitz');
INSERT INTO Author (AuthorName) VALUES ('Frank Herbert');
INSERT INTO Author (AuthorName) VALUES ('Andy Weir');
INSERT INTO Author (AuthorName) VALUES ('William Gibson');
INSERT INTO Author (AuthorName) VALUES ('Noah Gordon');
INSERT INTO Author (AuthorName) VALUES ('Carlos Ruiz Zafon');
INSERT INTO Author (AuthorName) VALUES ('Rebecca Gablé');
INSERT INTO Author (AuthorName) VALUES ('Stieg Larsson');
INSERT INTO Author (AuthorName) VALUES ('Dan Brown');
INSERT INTO Author (AuthorName) VALUES ('Gillian Flynn');
INSERT INTO Author (AuthorName) VALUES ('Jane Austen');
INSERT INTO Author (AuthorName) VALUES ('Jojo Moyes');
INSERT INTO Author (AuthorName) VALUES ('Diana Gabaldon');
INSERT INTO Author (AuthorName) VALUES ('Stephen King');
INSERT INTO Author (AuthorName) VALUES ('Bram Stoker');
INSERT INTO Author (AuthorName) VALUES ('Shirley Jackson');
INSERT INTO Author (AuthorName) VALUES ('Walter Moers');
INSERT INTO Author (AuthorName) VALUES ('Justin Cronin');
INSERT INTO Author (AuthorName) VALUES ('Erin Morgenstern');
INSERT INTO Author (AuthorName) VALUES ('Neil Gaiman');
INSERT INTO Author (AuthorName) VALUES ('Ken Follett');
INSERT INTO Author (AuthorName) VALUES ('Rachel Joyce');

-- Jetzt die Genres in die Tabelle 'Genre' einfügen
INSERT INTO Genre (GenreName) VALUES ('Fantasy');
INSERT INTO Genre (GenreName) VALUES ('Science-Fiction');
INSERT INTO Genre (GenreName) VALUES ('Historischer Roman');
INSERT INTO Genre (GenreName) VALUES ('Krimi');
INSERT INTO Genre (GenreName) VALUES ('Romantik');
INSERT INTO Genre (GenreName) VALUES ('Horror');
INSERT INTO Genre (GenreName) VALUES ('Drama');
INSERT INTO Genre (GenreName) VALUES ('Abenteuer');
INSERT INTO Genre (GenreName) VALUES ('Mystery');
INSERT INTO Genre (GenreName) VALUES ('Satire');
INSERT INTO Genre (GenreName) VALUES ('Mythologie');

-- Die Bücher in die Tabelle 'Book' einfügen
INSERT INTO Book (Title, Description, Rating, ReleaseYear, fk_AuthorId) VALUES 
('Der Name des Windes', 'Ein junger Mann namens Kvothe erzählt die Geschichte seines Lebens – von seiner Kindheit als Mitglied einer fahrenden Schauspielertruppe über seine Zeit an der Universität bis hin zu seinen mystischen Abenteuern.', 4.5, 2007, 1),
('Game of Thrones', 'In einer mittelalterlichen Welt kämpfen verschiedene Adelsfamilien um den Eisernen Thron. Intrigen Machtkämpfe und Magie bestimmen die Handlung die durch viele Charaktere erzählt wird.', 4.4, 1996, 2),
('Die Zwerge', 'Tungdil ein Waise der bei Menschen aufgewachsen ist muss sich seinem Schicksal stellen und die Welt der Zwerge und Menschen vor einer dunklen Bedrohung retten.', 4.3, 2003, 3),
('Dune', 'Auf dem Wüstenplaneten Arrakis entfaltet sich ein episches Drama bei dem der junge Paul Atreides in einen Machtkampf um die wertvollste Substanz im Universum das „Spice“ verwickelt wird.', 4.2, 1965, 4),
('Der Marsianer', 'Mark Watney ein Astronaut wird nach einem fehlgeschlagenen Marsmission versehentlich für tot gehalten und muss alleine auf dem roten Planeten ums Überleben kämpfen.', 4.4, 2011, 5),
('Neuromancer', 'Der Cyberpunk-Klassiker erzählt von Case einem heruntergekommenen Computer-Hacker der angeheuert wird um einen gefährlichen Hack in einer dystopischen Zukunft auszuführen.', 3.9, 1984, 6),
('Der Medicus', 'Der junge Engländer Rob Cole begibt sich im 11. Jahrhundert auf eine Reise ins ferne Persien um die Geheimnisse der Heilkunde zu erlernen.', 4.2, 1986, 7),
('Der Schatten des Windes', 'In Barcelona entdeckt der junge Daniel ein Buch das sein Leben verändern wird. Bald wird er in ein Netz aus Geheimnissen Intrigen und verlorener Liebe verstrickt.', 4.3, 2001, 8),
('Das Lächeln der Fortuna', 'In diesem Mittelalterepos wird die Geschichte Englands im 14. Jahrhundert aus der Perspektive des jungen Robin of Waringham erzählt der zahlreiche Intrigen und Kriege überleben muss.', 4.5, 1997, 9),
('Verblendung', 'Der Journalist Mikael Blomkvist und die Hackerin Lisbeth Salander versuchen das Geheimnis um das Verschwinden einer Frau vor 40 Jahren aufzudecken was sie in eine dunkle Verschwörung führt.', 4.1, 2005, 10),
('Der Da Vinci Code', 'Robert Langdon ein Symbologe wird in ein Netz aus Geheimnissen und Rätseln verstrickt das zu einer der größten Verschwörungen in der Geschichte der Menschheit führt.', 3.9, 2003, 11),
('Gone Girl', 'Nick Dunnes Frau Amy verschwindet spurlos und während die Medien ihn verdächtigen zeigt sich nach und nach dass ihre Beziehung und das Verschwinden dunkle Geheimnisse birgt.', 4.1, 2012, 12),
('Stolz und Vorurteil', 'Elizabeth Bennet eine junge Frau aus gutem Hause begegnet dem wohlhabenden aber stolzen Mr. Darcy. Ihre Beziehung entwickelt sich inmitten gesellschaftlicher Erwartungen und Vorurteile.', 4.3, 1813, 13),
('Ein ganzes halbes Jahr', 'Die lebensfrohe Louisa Clark wird zur Pflegerin des querschnittsgelähmten Will Traynor. Trotz ihrer unterschiedlichen Lebensansichten entwickelt sich zwischen den beiden eine unerwartete Liebesgeschichte.', 4.3, 2012, 14),
('Outlander - Feuer und Stein', 'Die Krankenschwester Claire Randall wird auf mysteriöse Weise ins Schottland des 18. Jahrhunderts versetzt wo sie auf den Highlander Jamie Fraser trifft und in einen Strudel aus Abenteuer und Liebe gerät.', 4.2, 1991, 15);

-- Die Beziehung zwischen den Büchern und den Genres in die Tabelle 'BookGenre' einfügen
INSERT INTO BookGenre (fk_BookId, fk_GenreId) VALUES (1, 1); -- Der Name des Windes ist Fantasy
INSERT INTO BookGenre (fk_BookId, fk_GenreId) VALUES (2, 1); -- Game of Thrones ist Fantasy

-- (Weitere Einträge werden hier analog zu den anderen Büchern und Genres gemacht)
