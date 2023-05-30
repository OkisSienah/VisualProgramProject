CREATE TABLE [dbo].[History] (
    [no_makanan]   INT           NULL,
    [user_id]      INT           NOT NULL,
    [nama_makanan] VARCHAR (MAX) NULL,
    [jumlah]       INT           NULL,
    [harga]        INT           NULL,
    [total]        INT           NULL,
    [waktu]        DATETIME      NULL
);

