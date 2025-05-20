INSERT INTO `produtos`
(`cod_barras`,`descricao`,`valor_unit`,`unidade_venda`,`categoria_id`,`estoque_minimo`,`classe_desconto`,`imagem`,`data_cad`, `descontinuado`) VALUES
('7894563120876','Parafuso para motor de arranque caixa 10un', 9.98,'unidade',21,0,0.12,null,default,default),
('7894564583876','Pretinho pneus', 11.98,'unidade',19,0,0.20,null,default,default),
('7894564488876','Pastilha de freio para Fusca caixa com jogo', 25.79,'unidade',21,0,0.12,null,default,default),
('7894647680876','Pneu Pirelli 14 175x60', 529.74,'unidade',16,0,0,null,default,default),
('7894564159876','Oleo Lubrax 5w30 Litro' , 34.98,'unidade',20,0,0.15,null,default,default),
('7897521120876','Limpador de parabrisas Dyna DX18 par', 65.64,'unidade',21,0,0,null,default,default),
('7894541258876','Bateria Moura 60A', 463.98,'unidade',21,0,0.05,null,default,default),
('7894563125874','Radiador Denso Fusca 66', 897.98,'unidade',21,0,0,null,default,default)
;

select * from produtos;

update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400001;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400002;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400003;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400004;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400005;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400006;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400007;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400008;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400009;
update produtos set imagem  = (select imagem from produtos where id = 7400012) where id = 7400010;


