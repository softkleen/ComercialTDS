call sp_nivel_insert('Master', 'MTR');
call sp_usuario_insert('Wellington Vieira dos Santos','well@gmail.com', '1234', 1);
update usuarios set senha = md5('123') where email = "maria@senac";
select * from estoques;
select * from usuarios;
select * from categorias;
select * from produtos;
select * from clientes;