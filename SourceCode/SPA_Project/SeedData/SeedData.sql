use SPA_Project

insert into ServiceTypes(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName) values(1,GETDATE(),GETDATE(),N'Massage với dầu thiên nhiên')
insert into ServiceTypes(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName) values(1,GETDATE(),GETDATE(),N'Liệu pháp chăm sóc sắc đẹp')
insert into ServiceTypes(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName) values(1,GETDATE(),GETDATE(),N'Saunna')
insert into ServiceTypes(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName) values(1,GETDATE(),GETDATE(),N'Dịch vụ khác')

update ServiceTypes
set ImageUrl='https://lh3.googleusercontent.com/0imLuxV-JRRd1VH2IU1K_t1n8scehabNxt-cOuk0PAnUtn-SfLYzmp-eL06dPFa3wIADc0J_fotftkEnW6GIfRXWZz9lhaoMB0HSdzaRkwGr0Pv592VjsXs7Wk9e8mvlfX-aPJZR=w2400'
where Id=1

update ServiceTypes
set ImageUrl='https://lh3.googleusercontent.com/rY7Ck1f6K4l5rupTXXt37lGtP95hPTEC4KdczgSOPMuNAjVDZI-4mJ6cpJpxcaRWg8n6Bbp1ULm0zzqzjCq9f7Yj20I-aN2FZk6Rxmof0gvCoFZZ3DU6_0n2UiwZfVoV3iVb3NYb=w2400'
where Id=2

update ServiceTypes
set ImageUrl='https://lh3.googleusercontent.com/CJH-VbsdjQO-h5I0xZGdruREeexDAXVtE30XfJ5TvfQvnQyfXBxmtTB4KBrK550GSRKC84Rhg23q_8iiKwo11KaBzx-bjnhnAGwHWnkZGJcXTgn4Bmuvm7f64FjXJhsQBA_AeOhz=w2400'
where Id=3

update ServiceTypes
set ImageUrl='https://lh3.googleusercontent.com/ujkCq5OQyVHoDZH6BALgf4QzeEFrqD2jsj1rXRVXh_ViDlNug2gH1V2OQYLxXxWAJrRI7t3IxcicC5LKchhk4bZkDRUJHEoFZkva4pQLdRFJMHPFsQ69nLacZ8B34aThqrln2cEQ=w2400'
where Id=4



insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Massage Thụy Điển', 400, N'Massage lực vừa, thư giãn cơ',60,NULL,1)
update Services
set ImgUrl='https://lh3.googleusercontent.com/oKEmZyaJ3AezwzYaASlmIswsVGsfwVMQEzk8Rcuk3hm2Nsd7aeQzcHt7AgwF39ieg64dtsyAsOczZjO9Nhqkg-GTeTlhKVQEZWVBd-fSQP1cCVSWP9eUm1U2dSqi4iL40i8GoqLc=w2400'
where Id=1

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Massage Thái Sabai', 400, N'Massage lực mạnh, kéo căng cơ thư giãn, giảm nhức mỏi',60,NULL,1)
update Services
set ImgUrl='https://lh3.googleusercontent.com/tPKGEwvprCmuljCe6pNBMJaRwMfJFcW5Yo6IwlMB6ANXt8IAnxLObXzwvLDuUZzzUPqqyXEJhXbEgKv25QZN0OUD4DBESeEbaVry19qT9ovG4k98Pz0NjX8Efz6bCQufuiyofaQM=w2400'
where Id=2

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Massage Đá nóng', 550, N'Massage lực mạnh, làm tan mỡ, thải độc',90, NULL,1)
update Services
set ImgUrl='https://lh3.googleusercontent.com/XSPSarMvwPBeSnLjUcXMPcKhycla8PJLjfEbf4EGClK-PQbDrIwm5kVWdaLWXjwm1KMfD132V2UFBHnuzbEE_JGdNUyOeeke2JU5X0ELUbrgwL1IkxjzOmyKhfvwvUbopQNOtpjh=w2400'
where Id=3

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Massage Cổ truyền Việt', 550, N'Massage lực nhẹ nhàng, thư giãn dễ ngủ, kế hợp ngâm bồn với lá Dao Đỏ',90, NULL,1)
update Services
set ImgUrl='https://lh3.googleusercontent.com/VveDvrK64j8tDLrKLzvr8EeInA12yvnaTQcQ9zxvfL3XeFok90a2iYI2QrOpkqQHpn6_Q_dI9BVWhhyWmHVTrrdA0RIFBQlWRBUMUWaVVhyFqGqLKMCf7Z_AzjHHOXcnHz-bRzBp=w2400'
where Id=4

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Chăm soc da thâm sạm do ánh nắng (trẻ hóa da)', 550, N'Sử dụng liệu pháp các vị đông y chăm sóc, giúp da sáng trở lại',60,NULL,2)
update Services
set ImgUrl='https://lh3.googleusercontent.com/GkCUTUGPwx17jCGUnfq4aEy5utDWh8QxAe5aVJKH78If9yhb_VHuUnW2SYByDcG0P5kp_akgYUA9sI5-mSKD2NVl-NKyp0rmv3FuBpeR9JSjI9Qr2VlcO-FccVxKIHKZIufUH3Eu=w2400'
where Id=5

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Chăm sóc da Khô (da nhạy cảm)', 550, N'Sử dụng liệu pháp hoa hồng kết hợp sữa dê, giúp da khỏe mạnh',60,NULL,2)
update Services
set ImgUrl='https://lh3.googleusercontent.com/K-hWvPnJrMHp2RHaqeRHyfKs0_pZR6rDmNElQjJn55YyWQgASK0AhkdWsyICe4kHhPba3KCo9iWxaNB1OZ1t0yC-WpC6DC5QnDeTKnH8UZrcPDWlyjaSQAqFDMNkvWOj1MS8LUwO=w2400'
where Id=6

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Chăm sóc da nhờ (se khít lỗ chân lông)', 550, N'Sử dụng liệu pháp tinh chất chanh cùng tinh chất bạc hà, giúp cân bằng đồ ẩm',90,NULL,2)
update Services
set ImgUrl='https://lh3.googleusercontent.com/X52X2jisSZpWEdl4QupHPGfLs5WlZrhWNVkDRPq2fRswLlB0d_Y_24DCb70eTOAL6lSAJ0d9slijyyil2-gpfnC2H-AtITo9MciKfrRknRX2r-N-dvAyY-e_oilVBKvzx_Ov8VQF=w2400'
where Id=7

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Combo dịch vụ xông hơi + xông khô + ngâm bồn', 300, N'Xông hơi khô giúp sưởi ấm cơ thê, thư giãn tinh thần, giảm đau nhức và mệt mỏi',30,NULL,3)
update Services
set ImgUrl='https://lh3.googleusercontent.com/n0Lqg23IMybzoGDZF6QRtGEPexDcVImLAu1Qf-W_GCw5NSiuJvGZz1QfM3EB96NzriJBwBygpopoJky1xnMDNyXeghjHYU42E6UC_eTffis67QmF2jDbl-CZS6lon-FQgNs6_dJL=w2400'
where Id=8

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Gội đầu thư giãn', 200, N'',30,NULL,2)
update Services
set ImgUrl='https://lh3.googleusercontent.com/2Wj17P7ERz72No8KA-RxUm9kdb2Q1oxZbK5Sa5tPi0WLD08duNCjuINpmueKUGo21degcHolJ8lqfqKLkJFhR_PodSAcAu_lflgx3w01m3vwkM5frVR1pdVSinJV2sJhypIwQj-S=w2400'
where Id=9

insert into Services(EntityStatus,LastCreatedDate,LastUpdatedDate,ServiceName,Price,Content,Time,ImgUrl,ServiceTypeId) values(1,GETDATE(),GETDATE(),N'Chăm sóc móng', 200, N'',90,NULL,2)
update Services
set ImgUrl='https://lh3.googleusercontent.com/M9TzWZidJ1iF-bhwqAgoxozjqIj47NQz81lqwSp6r1fn_OM_OJKrzUF_jV6IyDHfYBGhNRwgN2mc7RCgQa_gaeDKtBelQOSxXdEY5AN1zeZVlqImu4mDZB44_W3Z1nX_COhCqjPB=w2400'
where Id=10


insert into Outlets values(1,GETDATE(),GETDATE(),N'Chi nhánh Hồ Tùng Mậu',N'76 Hồ Tùng Mậu, Phường Bến Nghé, Quận 1, TPHCM','',10.772422,106.703642)
insert into Outlets values(1,GETDATE(),GETDATE(),N'Chi nhánh Nguyễn		 Chiểu',N'65 Nguyễn Đình Chiểu, Phường 6, Quận 3, TPHCM','',10.774905,106.684852)
insert into Outlets values(1,GETDATE(),GETDATE(),N'Chi nhánh Hoàng Văn Thụ',N'134 Hoàng Văn Thụ, Phường 8, Quận Phú Nhuận, TPHCM','',10.799365,106.676847)
insert into Outlets values(1,GETDATE(),GETDATE(),N'Chi nhánh Phạm Văn Đồng',N'172 Phạm Văn Đồng, Phường 3, Quận Gò Vấp, TPHCM','',10.816943,106.684850)
insert into Outlets values(1,GETDATE(),GETDATE(),N'Chi nhánh Nguyễn Thị Minh Khai',N'9 Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1, TPHCM','',10.787337,106.702411)

update Outlets
set Name = N'Chi nhánh Phan Văn Trị', Address=N'591 Phan Văn Trị, Phường 5, Gò Vấp, TPHCM', Latitude=10.825909,Longitude=106.689564
where id=5

INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)
INSERT INTO Rooms(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status)
VALUES (1,GETDATE(),GETDATE(),NULL,0)

INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,1)


INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)
INSERT INTO Beds(EntityStatus,LastCreatedDate,LastUpdatedDate,ExtraNote,Status,RoomId)
VALUES (1,GETDATE(),GETDATE(),NULL,0,2)

