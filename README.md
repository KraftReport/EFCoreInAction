# EFCoreInAction
Learning entity framework core


CREATE TABLE Author (
    AuthorId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NULL,
    WebUrl NVARCHAR(500) NULL
);


CREATE TABLE Book (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NULL,
    Description NVARCHAR(MAX) NULL,
    PublishedOn DATETIME NULL,
    AuthorId INT NULL,
    CONSTRAINT FK_Book_Author FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId)
);


INSERT INTO Authors (Name, WebUrl) VALUES 
('J.K. Rowling', 'https://www.jkrowling.com'),
('George R.R. Martin', 'https://www.georgerrmartin.com'),
('Stephen King', 'https://www.stephenking.com'),
('Haruki Murakami', 'https://www.harukimurakami.com'),
('Agatha Christie', 'https://www.agathachristie.com');


INSERT INTO Books (Title, Description, PublishedOn, AuthorId) VALUES
('Harry Potter and the Philosopher''s Stone', 'First book in the Harry Potter series.', '1997-06-26', 1),
('A Game of Thrones', 'First book of A Song of Ice and Fire.', '1996-08-06', 2),
('The Shining', 'A horror novel by Stephen King.', '1977-01-28', 3),
('Norwegian Wood', 'A nostalgic story by Murakami.', '1987-09-04', 4),
('Murder on the Orient Express', 'A Hercule Poirot mystery.', '1934-01-01', 5);