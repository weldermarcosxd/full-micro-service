using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pdi.Full.Micro.Service.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Sequencial", "Descricao", "Id", "Nome", "Preco", "QuantidadeEmEstoque" },
                values: new object[,]
                {
                    { 1L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("1ac9bae7-127a-159d-70a0-01fc4fca2952"), "Intelligent Concrete Chair", 43567.7727223250879104m, 679578.280080977523488m },
                    { 2L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("51dce32e-27ec-8ce7-b055-d02deeb259c8"), "Fantastic Wooden Tuna", 60966.269529584079266m, 563814.595803341134424m },
                    { 3L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("b4eb64f1-fa2f-1f9c-c04f-6927f3ec642f"), "Handmade Steel Car", 815390.305627768180718m, 883322.373618422470594m },
                    { 4L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("00688ce2-31e7-7ac6-4caf-c76105147a57"), "Unbranded Concrete Car", 513663.38390180754274m, 950248.982377279245910m },
                    { 5L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("ee3a7709-2d8b-fbd2-ec9e-f32c89d17f23"), "Awesome Soft Shirt", 682094.909085871447164m, 143422.497347933616996m },
                    { 6L, "The Football Is Good For Training And Recreational Purposes", new Guid("60cf30fa-5f86-9c1a-de0c-d49ba66df26c"), "Awesome Metal Pants", 36883.7067670543347692m, 579139.303154331133492m },
                    { 7L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("0a7fac6b-7b12-9ea3-ba2d-c29dd4523830"), "Ergonomic Cotton Pants", 675002.633867558252948m, 111018.124521850886912m },
                    { 8L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("20527413-d78d-747b-9bd8-323745a44402"), "Refined Wooden Pants", 114455.981341093496972m, 337327.809855764978532m },
                    { 9L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("1a38e243-7633-1bd9-1d53-6448b7807296"), "Rustic Plastic Keyboard", 498737.763151285746386m, 937281.919333388202048m },
                    { 10L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("8120c030-e94e-e25d-d496-a1f0c7c4c1cc"), "Sleek Fresh Bacon", 860452.183012192164m, 808446.189488361236052m },
                    { 11L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("3d9f3de9-bab9-4cf7-25b0-1aca8b9e7c9a"), "Tasty Frozen Ball", 901836.245008957633890m, 526711.541877770398078m },
                    { 12L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("6de98c35-63b0-d226-e3a5-6031ac54838c"), "Practical Metal Chair", 964229.110709236661370m, 320315.941520808696054m },
                    { 13L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c000afc8-8e68-6112-a517-0f430096b76e"), "Licensed Wooden Gloves", 914023.216235628432566m, 256449.474327807548436m },
                    { 14L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1bd0215f-d51e-03b3-5ec0-eab1c70346b0"), "Sleek Rubber Keyboard", 560843.851845817932470m, 181191.188236022765752m },
                    { 15L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c6088922-5547-dc0f-bed4-9ad818c4cc44"), "Unbranded Concrete Pants", 313028.15437368914150m, 297800.01037182805792m },
                    { 16L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e3adc7be-8af7-cb07-d854-4f37802c2512"), "Tasty Granite Salad", 436520.822812337292542m, 392586.131848293959744m },
                    { 17L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("3382fbfa-9b62-3ec8-f359-fba3f4bfaa94"), "Gorgeous Plastic Cheese", 183424.564911068482136m, 861175.136815336665890m },
                    { 18L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("52ff11ea-6089-44a1-eabe-b8604d47bf3a"), "Licensed Plastic Sausages", 25477.9182371879177474m, 295943.051214987799452m },
                    { 19L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("df3c614d-f756-553f-46f8-a8326af6ab5d"), "Sleek Granite Table", 665250.434089031818878m, 799126.463512143467466m },
                    { 20L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("414f1821-1dbc-feaf-55c4-aa6cb0fe6c5a"), "Unbranded Fresh Ball", 835512.933886132173316m, 839968.255014142095976m },
                    { 21L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("67b6f34b-791b-def3-7769-d1af73f71c42"), "Rustic Steel Computer", 747084.929837457983388m, 953434.26071221483490m },
                    { 22L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("47154b61-046b-cb6a-4c23-6ec511789397"), "Incredible Rubber Salad", 236177.836262114766536m, 811073.262632725439010m },
                    { 23L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("d186fddd-2b7a-5e08-a22a-5cb8bb7bf520"), "Intelligent Rubber Tuna", 998785.4826781394978m, 187299.047291202223908m },
                    { 24L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("df1562bc-66f2-c168-4029-4473590696a8"), "Intelligent Wooden Towels", 246899.728433866535378m, 933594.202344931929858m },
                    { 25L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("1a6aeb09-5af0-4c8b-efa0-40f454b77f81"), "Small Frozen Fish", 703897.625956017495830m, 561008.322869258227704m },
                    { 26L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("e9972f3f-1e2a-0ab7-7a41-686ffda2bbe7"), "Fantastic Granite Mouse", 100591.624807504021688m, 227502.814468420054082m },
                    { 27L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("4ac14f4b-518f-0b8d-ea97-2d01a22ef46c"), "Small Concrete Ball", 744132.126761415946708m, 761541.729910920009148m },
                    { 28L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5d9e2736-c087-747b-178f-a063906fe273"), "Fantastic Concrete Ball", 92988.9071189389097498m, 203428.502841313605734m },
                    { 29L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("35ef1622-f211-7d23-744e-dd4e7c2a57e4"), "Handcrafted Metal Fish", 625207.583857037454588m, 640466.26190660432062m },
                    { 30L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("6c4ab175-6440-7232-07ca-fb22fa32d394"), "Incredible Granite Keyboard", 86210.6365636169335302m, 830289.861665902506106m },
                    { 31L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("9f807d8c-6a4d-ffba-4fb9-86e7d12733b1"), "Sleek Soft Towels", 233392.674684691062052m, 668915.524589740157070m },
                    { 32L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("3b61dca9-7d6e-ef64-f400-7d014a093332"), "Generic Plastic Tuna", 30866.5427026653322516m, 709078.625906680870462m },
                    { 33L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("cbf59647-7062-8dcf-5c21-965324fe0050"), "Generic Plastic Sausages", 423540.094962927914376m, 410590.461304389030092m },
                    { 34L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7ab19d16-f91b-84e8-7cad-5171b1f96bf6"), "Generic Concrete Salad", 254493.745494217038548m, 67183.3022725329251876m },
                    { 35L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("d3136b2c-97d2-d6c9-aad1-36d46c39b495"), "Handcrafted Metal Keyboard", 437841.708326002981658m, 367777.402710708470030m },
                    { 36L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("db4b803d-c873-f598-242b-e53ae2bcfa88"), "Sleek Frozen Gloves", 351024.716560049782226m, 98107.2543268655204668m },
                    { 37L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("b9d2813b-3d4f-c5b8-4b01-db3be974c284"), "Rustic Plastic Towels", 987371.092275223961284m, 178291.843644808545582m },
                    { 38L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b4af9f6e-4109-f03f-f197-879f3eb4cfef"), "Ergonomic Fresh Cheese", 606991.804291968447990m, 246885.72324630596652m },
                    { 39L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("f7d69f45-739c-b9b3-66ed-d68e42869069"), "Practical Plastic Fish", 247639.459101114241954m, 919590.221250505134748m },
                    { 40L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("6c9028ee-7821-0e3f-0f9d-6c87d117a4c8"), "Intelligent Rubber Shoes", 181171.468509600297476m, 329602.398619033353702m },
                    { 41L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("756f22d8-71f2-096d-fec4-a08799432645"), "Handmade Wooden Ball", 230550.62658767462430m, 804707.272797312573846m },
                    { 42L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("664f9337-5c76-60e3-f30f-b8fd695999e9"), "Licensed Soft Mouse", 170539.815039711763952m, 516568.020076217575352m },
                    { 43L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a8fbf222-f406-e579-ce88-8cb215ffac2a"), "Unbranded Granite Pizza", 820940.893614691004476m, 907052.338550559686270m },
                    { 44L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("6940890a-80aa-5d70-a71e-f096a79f263d"), "Handcrafted Fresh Chips", 437228.772056694972024m, 853124.049986086528802m },
                    { 45L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("3cd4ec2a-29fc-4d40-2c05-a377f52d4fe4"), "Unbranded Soft Sausages", 52565.7797607726189152m, 690309.604526421707216m },
                    { 46L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("2d8a38b8-5f2d-dc8a-f775-277dd077b7a5"), "Rustic Soft Pants", 945519.641444502028866m, 244739.16280744543050m },
                    { 47L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("32beb780-2169-7282-efd6-12d025610b1c"), "Licensed Concrete Computer", 567887.620332234784506m, 38909.8317314238015142m },
                    { 48L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("74609e44-1db4-363c-5df0-61166ce6bda9"), "Handmade Steel Car", 282988.170755484538084m, 179260.858953134052862m },
                    { 49L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("ced729f9-170b-4800-fbf8-696d3213f65a"), "Handmade Wooden Towels", 885623.875767727965956m, 746841.683173672283948m },
                    { 50L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("638a8bad-eb68-8891-6fa1-91c04362de5a"), "Practical Metal Table", 790599.102409211782842m, 266730.280948456183830m },
                    { 51L, "The Football Is Good For Training And Recreational Purposes", new Guid("0f2e1222-25de-c7fd-754e-d9dcefa1090d"), "Fantastic Soft Bike", 414919.871652653015888m, 504692.723206931815206m },
                    { 52L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("37efb451-2f4c-ad5c-9e9f-5a07b62a2031"), "Awesome Granite Soap", 450103.455836965912644m, 307628.654344179798562m },
                    { 53L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("b34444af-3a13-5a58-d2f3-5c0c42c18503"), "Generic Granite Mouse", 918339.402567148504746m, 848827.962688947307464m },
                    { 54L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("46c1679f-1c2a-3a7c-d8a2-64e543001c07"), "Practical Frozen Chicken", 583550.324977679842672m, 48822.108189682335812m },
                    { 55L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("50949072-74cf-02cb-5b27-6dab86f32218"), "Handcrafted Soft Table", 915358.76948724958710m, 384163.610181900982684m },
                    { 56L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5cf5fab5-4e44-7b89-5e92-ef589e1e2574"), "Awesome Rubber Keyboard", 731782.639350942165704m, 276634.129551136362996m },
                    { 57L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("2e1a8dba-1dc9-877b-b9ce-f4746278d859"), "Incredible Soft Chips", 94824.5572523528003068m, 606995.555647343722234m },
                    { 58L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("3b9d3a0a-283c-d32a-d322-412afb61da89"), "Unbranded Cotton Chips", 653632.992105593255616m, 836729.629088869901050m },
                    { 59L, "The Football Is Good For Training And Recreational Purposes", new Guid("b30898c5-753c-52ee-dd02-1ea33c2e4569"), "Intelligent Granite Soap", 823569.685652895412878m, 523568.890984454755338m },
                    { 60L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("b46f3c12-b01d-f3f6-71dc-fdd7357f07b3"), "Awesome Wooden Chair", 147707.867654045863256m, 534042.531301024227554m },
                    { 61L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("24739540-ab9e-6ec9-d63f-fd2f0717445c"), "Licensed Steel Bacon", 367682.39807845311456m, 16554.6757715260421124m },
                    { 62L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("04bb58a7-8f4e-e1d7-2f8d-d21aef86e2f3"), "Unbranded Fresh Chicken", 649723.682241829620414m, 923467.897723442678136m },
                    { 63L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f55fe8c0-ddaf-a6a4-4d34-83f99a2c26c8"), "Unbranded Concrete Gloves", 130106.745536902502172m, 349994.317329751364428m },
                    { 64L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("4e7c4f4a-b542-97b9-243a-d9ace16061c3"), "Fantastic Rubber Shirt", 97296.9406006282142028m, 676573.072378400949496m },
                    { 65L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("80200b24-28db-2eae-c69c-b5a6173cd280"), "Licensed Frozen Tuna", 982452.783069708045592m, 226022.573970675970544m },
                    { 66L, "The Football Is Good For Training And Recreational Purposes", new Guid("0bd2bda8-1c4e-0b60-4bef-6a583d788c42"), "Incredible Cotton Tuna", 232750.60295387309198m, 787065.328804828126732m },
                    { 67L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("902c823c-1917-ba24-2c63-e53543594403"), "Practical Plastic Bacon", 660165.54947811038030m, 368250.702195358607528m },
                    { 68L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("bcddd3f9-211f-5597-623a-9adb24739450"), "Generic Fresh Car", 63098.0531193928724970m, 723339.34354477955128m },
                    { 69L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("24bd3f5f-9017-d0c7-5483-96feae1e54ea"), "Practical Granite Computer", 569017.178059411811912m, 289497.556158970693518m },
                    { 70L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c72ca58b-a88d-577b-daf2-74661e5d63d4"), "Tasty Soft Gloves", 918960.40478858457786m, 80846.4700093363988004m },
                    { 71L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("9126f350-2e79-d265-b173-ded2edd96a29"), "Awesome Fresh Chips", 176981.418394477287956m, 419082.587138493393312m },
                    { 72L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("1cd7c0b2-8fd2-2c78-1b25-3b720ad3b3e2"), "Tasty Steel Car", 977461.08396934221316m, 109031.708137335601624m },
                    { 73L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("1a8fa0a1-450a-1699-41e0-f4684574aeaf"), "Gorgeous Wooden Sausages", 815898.358790174823688m, 455856.661132431308846m },
                    { 74L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("264c5f29-6255-2543-3c65-581878c00980"), "Rustic Steel Sausages", 572468.11596514819666m, 404356.226621482332894m },
                    { 75L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("93d8dac4-938d-dec7-ac56-11f57a83d931"), "Tasty Fresh Towels", 354249.894808849383888m, 190112.382814598923750m },
                    { 76L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("2d71b5d0-9ec5-ed86-ed73-69f10bc780ed"), "Small Concrete Car", 532969.525274585572464m, 736848.57978866302646m },
                    { 77L, "The Football Is Good For Training And Recreational Purposes", new Guid("ec803ac1-b564-f1f0-5acb-edd64ca14e3b"), "Gorgeous Granite Keyboard", 960098.438926769749024m, 480859.445005062552248m },
                    { 78L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("2c232dae-444b-ecd2-7444-346f89f5dce0"), "Awesome Plastic Ball", 665639.924772635893704m, 927138.30055864032610m },
                    { 79L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("7505e472-ce30-6b3a-3c83-73e457e44754"), "Awesome Rubber Gloves", 500.797543791798222230m, 290043.654322473182116m },
                    { 80L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("83cbb17f-528d-0800-caa0-822ff356fdeb"), "Ergonomic Wooden Towels", 687137.321380052689112m, 425191.795069267094884m },
                    { 81L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("78d566ca-9c5a-03e7-1032-b1cd5322ea98"), "Incredible Plastic Tuna", 736297.594779658248414m, 81036.9097506248544630m },
                    { 82L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("a2b8c665-334c-540e-a307-464992ef392e"), "Handmade Soft Keyboard", 768512.730741192464544m, 107160.637113363133868m },
                    { 83L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("396cee5f-35cf-b0cb-7c98-aa9a4fe47784"), "Ergonomic Plastic Salad", 211449.928870715461162m, 25485.8950379721842716m },
                    { 84L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("fd58fca4-8f94-2d02-bcfc-5d3cf61b8e44"), "Rustic Plastic Car", 655104.829107165365112m, 841686.35599279126626m },
                    { 85L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("bf47e35f-9608-408d-a54a-9248a2da4b4e"), "Incredible Granite Shoes", 444344.747236662148132m, 17169.3059880569505248m },
                    { 86L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("32ebb9b0-6a4c-2254-a0cb-31d203ceb002"), "Intelligent Rubber Salad", 122634.259029413407156m, 865337.587022886600956m },
                    { 87L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("dcdbdf96-0787-214d-6c78-92f3205424a7"), "Small Wooden Salad", 356725.876463276171088m, 290657.171472621427746m },
                    { 88L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("0fa1f2d8-3621-badb-3bad-669e21962926"), "Handcrafted Plastic Keyboard", 370279.940246364388548m, 628598.98577476405350m },
                    { 89L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b7e9f006-f8af-2cd6-ec0e-b4812fbb7401"), "Ergonomic Soft Computer", 755870.30019136613402m, 362894.47407802026716m },
                    { 90L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("f4d69a45-22f4-3a0c-41a0-124082b99aea"), "Awesome Soft Soap", 826876.5708787507336m, 163990.806490562058338m },
                    { 91L, "The Football Is Good For Training And Recreational Purposes", new Guid("024eee3e-eab2-7c3a-293b-e16140ae576e"), "Handcrafted Plastic Chicken", 915620.695442483628926m, 386431.600801683671138m },
                    { 92L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ba104dd6-afe2-a538-c308-b1adc1a154af"), "Sleek Metal Sausages", 301369.910146289229370m, 170126.281988804519902m },
                    { 93L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("151b9231-e63d-debf-c4ae-4ffbbd480561"), "Awesome Granite Chicken", 534093.11537617287492m, 138726.885210878673592m },
                    { 94L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("25d8309b-113f-c295-3a78-ae937635713f"), "Gorgeous Fresh Shoes", 1724.14840391694955870m, 217439.735746415750486m },
                    { 95L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("961b0f98-c52f-46c4-bf51-50bb6c56f7d5"), "Refined Plastic Computer", 221377.111342209809364m, 673242.044000306029826m },
                    { 96L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("42b87706-a002-32ac-0211-c6de60f1ec03"), "Awesome Concrete Pants", 532680.686791797693396m, 83417.74129193374850m },
                    { 97L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e6c2e9d5-3782-250d-3d1f-bdf027705e14"), "Gorgeous Granite Soap", 215160.971392523573346m, 530926.71741547146194m },
                    { 98L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("dcf06e15-83bb-e7ef-a449-1836a7ffb603"), "Tasty Fresh Soap", 902282.672798723268644m, 454895.037000479419254m },
                    { 99L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("b3da815f-e8df-2ffe-e75a-9edeac3f38d0"), "Small Frozen Pizza", 487235.710126113805034m, 926039.792038983759456m },
                    { 100L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("66267b6e-6607-1cbf-5613-74a475e06a14"), "Small Metal Computer", 311819.254667127390232m, 988673.269047443208128m },
                    { 101L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f90fa8cc-447d-c8dc-568c-0b5b3131d937"), "Intelligent Cotton Table", 402058.590106199554024m, 779181.816959577351344m },
                    { 102L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("24165b6e-30b3-ad8b-0a66-867fb1089f68"), "Handcrafted Steel Keyboard", 19947.6246231681670056m, 904569.554645964426616m },
                    { 103L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("f2aec143-81da-915c-2fe9-8c1894868fdd"), "Rustic Steel Table", 80664.1308619023230266m, 278680.789816822644966m },
                    { 104L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("2e19413c-a606-2c1e-7fd9-f9022d75c467"), "Rustic Granite Bike", 747032.289189288490290m, 678361.841389636771934m },
                    { 105L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("1234c435-a0fd-4d9c-aea6-1790010a477d"), "Intelligent Frozen Bike", 945101.184589602412496m, 31090.9321802177795870m },
                    { 106L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b0009768-1990-9abb-42e1-644d67408ffa"), "Small Rubber Pants", 679503.570203864576554m, 699118.776431174660952m },
                    { 107L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("00eb31c6-d9e0-f320-4497-6ca03a40b63f"), "Practical Metal Tuna", 37868.8351623378036808m, 499073.067804233099270m },
                    { 108L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("86d9e4ce-32f6-45a0-0575-c44f741d91e5"), "Tasty Fresh Mouse", 483952.809531596125698m, 967804.250092519594218m },
                    { 109L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b1eee422-bdd0-3404-f9e7-e19f128e6bee"), "Tasty Wooden Sausages", 914475.132484282127590m, 34736.5977550604472102m },
                    { 110L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("111c7be9-a358-86f3-81a1-8c3793185f63"), "Generic Granite Towels", 751197.153613848981678m, 115590.216897614846978m },
                    { 111L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7a6bb4e8-d02a-715b-f4bd-a061535f4c0b"), "Handcrafted Metal Keyboard", 511208.876718356727690m, 827296.947727106355378m },
                    { 112L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("3a38ec02-bad3-00f5-0cba-dfc84bbfd4ba"), "Unbranded Rubber Soap", 87796.590751758313418m, 584271.125696835521152m },
                    { 113L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c53c8857-5692-ee26-feb0-4ecad23fd6d5"), "Handcrafted Frozen Chicken", 133076.113604727489026m, 780098.145795047015082m },
                    { 114L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1dac1e65-89f5-e58d-a526-7ed3c6d4a49d"), "Rustic Metal Chips", 301836.847936269781654m, 823459.710692938772692m },
                    { 115L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ea1ca144-5d89-5490-5421-08fe61a12a03"), "Generic Soft Mouse", 896065.697171253391536m, 290183.555156676954104m },
                    { 116L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("93ee7427-4939-12ec-dec0-1e257241714d"), "Incredible Rubber Pizza", 853184.59865729994418m, 699444.474834800550904m },
                    { 117L, "The Football Is Good For Training And Recreational Purposes", new Guid("a9a6216b-926d-3986-0e0b-ab4db10f33a0"), "Ergonomic Soft Pizza", 183500.017269767462928m, 685794.050407755006802m },
                    { 118L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("ce64bbe2-3ce8-92a7-00ed-e6118b055b56"), "Licensed Frozen Ball", 94837.3792262855011534m, 947123.315593202316756m },
                    { 119L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4de84b25-3b8e-292b-ac38-5bc921e2eb05"), "Practical Rubber Shirt", 321024.655809411283986m, 249583.676773480120336m },
                    { 120L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("7cfe696c-3e85-04d3-1526-86196b227ddb"), "Handcrafted Frozen Fish", 318567.979578534572464m, 171693.491214117800426m },
                    { 121L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c446d197-05a5-ea9b-c861-89a1110eecbf"), "Licensed Concrete Bike", 204165.964900882536742m, 559692.221798586633462m },
                    { 122L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("941d23c7-669a-2ef8-c362-1ea8fbaea400"), "Rustic Granite Chair", 982216.568422477284914m, 196234.353570429924156m },
                    { 123L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("ac03479d-0007-449b-fb24-ff5f8b66aeef"), "Handcrafted Frozen Mouse", 220871.290954092608884m, 314084.706242135178392m },
                    { 124L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("d0d1204e-0638-a2f3-d4e8-6f23c8605c9b"), "Licensed Rubber Bacon", 131224.057201608703504m, 362346.783202217209534m },
                    { 125L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8e389411-c7f6-9e3b-06b4-afe8bbef0ec0"), "Unbranded Frozen Cheese", 816618.109870279784468m, 18714.9747394918649676m },
                    { 126L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("5c9b58eb-4772-afe3-ff3c-9406638bc442"), "Practical Fresh Shoes", 321531.599561890751248m, 236407.938351096668162m },
                    { 127L, "The Football Is Good For Training And Recreational Purposes", new Guid("a6786779-c4a9-6ca3-1be3-0b0e2b0c1ded"), "Sleek Wooden Bike", 876070.50148924273650m, 547683.497999070267486m },
                    { 128L, "The Football Is Good For Training And Recreational Purposes", new Guid("74e77473-7450-5e73-aab0-028ea9d9e290"), "Incredible Frozen Keyboard", 895842.030818196992316m, 113485.546522260016386m },
                    { 129L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("3dd4a25f-4bfd-6125-ff87-28508a803fea"), "Intelligent Frozen Bacon", 199733.081686764696546m, 359074.034910396884194m },
                    { 130L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("e0c39aa6-1a75-ef77-b376-3ca761902596"), "Ergonomic Rubber Gloves", 966896.646424758560162m, 635736.76491480722224m },
                    { 131L, "The Football Is Good For Training And Recreational Purposes", new Guid("815838a6-2dda-9320-985c-422ffaff519d"), "Incredible Granite Pants", 586205.601333644509616m, 141360.454515286530478m },
                    { 132L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("42b4e4ab-9859-a5ec-b39d-32b843ede5af"), "Tasty Concrete Pants", 598875.723236062024192m, 153505.37109830378468m },
                    { 133L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("8de6e693-961f-e97f-d9ea-c51875edf701"), "Refined Granite Bacon", 214226.825636100822782m, 700340.93863245136974m },
                    { 134L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("8596516b-1483-5286-7828-39f7c2add6c3"), "Sleek Wooden Cheese", 378945.535956271306282m, 56674.4962972509110596m },
                    { 135L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f98413a5-6843-b227-0fbb-1cb46a25f42e"), "Awesome Soft Shirt", 601051.69130713317816m, 320527.106887336118336m },
                    { 136L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("a5e1612f-b140-6e43-428c-722aa65ecd45"), "Unbranded Steel Hat", 793832.515827581012424m, 725464.914953166232204m },
                    { 137L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("ebeb2987-3aed-acdf-3426-02215faa10c0"), "Intelligent Frozen Mouse", 376077.933747050195156m, 496322.838055776597124m },
                    { 138L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("fe1e5ba6-9667-56b5-794d-752c5afc0f7e"), "Gorgeous Soft Fish", 208710.953078183002152m, 396438.566849043548474m },
                    { 139L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("50a1b998-ee58-3f55-f583-0fbae1684a42"), "Gorgeous Plastic Pants", 824730.97063201980948m, 383427.172726787838666m },
                    { 140L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("eb301f7a-8d6e-e90d-125d-1392003a720a"), "Practical Fresh Shirt", 846169.620517619283510m, 739466.389296772538982m },
                    { 141L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("963f1450-6164-cf53-8282-4e4aab853493"), "Handcrafted Concrete Salad", 551516.110751264432616m, 799758.867481444999242m },
                    { 142L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("a410e012-1c0c-d61b-0e6e-695852f744bc"), "Handmade Wooden Cheese", 238022.270761434390144m, 120909.449738553888126m },
                    { 143L, "The Football Is Good For Training And Recreational Purposes", new Guid("f09c012b-5231-e16e-3be0-af1d5290f99f"), "Handcrafted Granite Bike", 203858.198113165343246m, 212626.685990472514610m },
                    { 144L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("1fe8d989-e9a3-ade5-a108-45b1ba24ebaa"), "Practical Wooden Keyboard", 125364.99361427131448m, 486708.160954677258108m },
                    { 145L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("45c82e41-deb0-be06-7743-628302c607dd"), "Licensed Frozen Bike", 710561.875499672751468m, 631695.480593536029952m },
                    { 146L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a14b7676-d692-0821-2cc7-2d1c8c38ca3e"), "Practical Concrete Hat", 462708.784040148084866m, 618212.309943832262150m },
                    { 147L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7c32fb66-7223-bb7c-4331-891d98b57421"), "Ergonomic Wooden Mouse", 951785.353063619727734m, 165607.53129439498376m },
                    { 148L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f1ec114b-0b89-d2dc-5043-0f6f0bff331b"), "Tasty Plastic Gloves", 461947.608925360359148m, 750743.251821950381086m },
                    { 149L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("be7cbb33-60da-2fae-9b0f-0d42e1523f19"), "Generic Steel Chicken", 110700.610619840960990m, 492779.637855112171282m },
                    { 150L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cdbeb02b-ee4b-6193-8a00-59a965342a8c"), "Licensed Steel Salad", 795416.803950332429756m, 138171.863449543416354m },
                    { 151L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("78e2ccd3-0af7-199d-c189-c178805f3fc0"), "Rustic Rubber Pants", 676790.354746197344772m, 415141.94536612870064m },
                    { 152L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("784e817d-95fe-20f4-7df5-3d6f14602e7f"), "Awesome Soft Gloves", 442654.84853535231036m, 724402.151302283785032m },
                    { 153L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("5899bc36-fc19-b5f1-1a54-d5ac40a3d59f"), "Small Metal Chair", 133602.142919578755202m, 259674.523709360885106m },
                    { 154L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("90dcb210-a5be-fd5d-1932-c2e75e451a73"), "Intelligent Cotton Pizza", 232048.688904139999108m, 971354.067921554736848m },
                    { 155L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("3f4f9864-c9f7-329b-8a93-4a60dd8d3ac3"), "Sleek Rubber Hat", 363925.464690367918494m, 190284.874765653331672m },
                    { 156L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("113e79aa-268c-ce48-b6c0-2f2975977f64"), "Sleek Cotton Computer", 997448.7557856986296m, 853719.613104542909632m },
                    { 157L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("242bbe81-cebb-66c4-448f-a9306f05b713"), "Generic Wooden Ball", 259472.814058649993368m, 720738.731806289430728m },
                    { 158L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("975dcb48-de95-f502-5c5a-358863aa30df"), "Rustic Metal Ball", 660598.621036909530412m, 594523.301967695970644m },
                    { 159L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("75f40c56-5473-cdc6-9d04-eb05034debe8"), "Handmade Granite Towels", 796172.379547339213434m, 568653.889788871806148m },
                    { 160L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b1bbadfa-4fe5-b4bc-6917-fe72b1a9369f"), "Practical Metal Fish", 613636.602506068440544m, 47745.1639879369470882m },
                    { 161L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("f6010996-feab-6265-f792-eb0616bd56f1"), "Intelligent Fresh Fish", 305915.553920752497832m, 786314.55761391951164m },
                    { 162L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("573135a7-f1e7-cb90-7a78-99f5a8f0ff14"), "Rustic Fresh Bike", 643999.861142110715182m, 209596.827447513719986m },
                    { 163L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("99b062b8-a843-c50c-addf-886d441f0924"), "Awesome Steel Chicken", 737683.334737274790210m, 315933.702822002622656m },
                    { 164L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("c292da8e-334f-4167-feb5-a7959166fa1c"), "Licensed Fresh Bike", 474615.577369072799748m, 779717.354636279855784m },
                    { 165L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("27576ca6-41e8-6b4a-b58e-e7a091940236"), "Refined Wooden Towels", 817397.651617318172218m, 654477.556197658693222m },
                    { 166L, "The Football Is Good For Training And Recreational Purposes", new Guid("03722dd9-877b-b1fd-a414-99a93e60599a"), "Fantastic Plastic Chips", 901850.696518864556270m, 248015.587497753944158m },
                    { 167L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("716357c5-9165-9b44-3888-a23728360132"), "Gorgeous Frozen Bacon", 916003.475380469221832m, 212338.313212320224408m },
                    { 168L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ad9a5312-b5ee-b50d-d3bd-ca376e6abfc0"), "Practical Soft Salad", 153270.58631054429934m, 277691.382792852650542m },
                    { 169L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("84b65676-009b-5e01-f416-df0f8113b11d"), "Tasty Steel Shoes", 341407.286933963504194m, 952236.458023283003984m },
                    { 170L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("c23c47c2-3d4e-7a8c-bf2c-a7d879fbaaa4"), "Handmade Granite Ball", 471435.712892863471650m, 119908.63635743765362m },
                    { 171L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("39622626-482d-a788-2a32-d5e6f3beba9d"), "Ergonomic Fresh Keyboard", 304692.703964615301516m, 382601.83717014525330m },
                    { 172L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("6385f626-419a-39d7-1e49-4dbc93f96a73"), "Licensed Cotton Pizza", 561306.889298417175118m, 376391.187329861776516m },
                    { 173L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("bca67956-4fbc-0046-473f-25dfdc0263fd"), "Tasty Fresh Pizza", 894983.605691065680286m, 74387.336592071269916m },
                    { 174L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("728d2ef2-92e5-b569-5799-e819bc259419"), "Fantastic Soft Bacon", 324585.010098129465104m, 802175.51863796401958m },
                    { 175L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("f33c5703-f8bf-0c51-ac56-2d0267cce0b5"), "Rustic Granite Car", 351533.224413478041334m, 314228.771732293621812m },
                    { 176L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("ba4c64dc-b006-1df1-aa4b-0f20c2676f48"), "Intelligent Wooden Soap", 4574.84746130333196690m, 895465.409437750259698m },
                    { 177L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("da7729da-3e3d-08d2-18b8-4aad0d880400"), "Fantastic Wooden Bike", 759140.750517128400668m, 888334.799248221161254m },
                    { 178L, "The Football Is Good For Training And Recreational Purposes", new Guid("e11181ca-1cae-12b3-c84f-b3f438299ffa"), "Practical Metal Keyboard", 968954.765509986157214m, 793018.533108809705904m },
                    { 179L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("ccf9ac69-c730-6868-bb72-bde9e496e759"), "Fantastic Plastic Mouse", 338062.189645401461734m, 765504.863249597479228m },
                    { 180L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("d9ae72dc-55e3-fd85-4a6c-7f6961cf4543"), "Ergonomic Concrete Hat", 206221.853836031442872m, 244269.72019300253716m },
                    { 181L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("780103a3-fd8b-1cf8-dc61-83940c69da14"), "Refined Granite Pants", 969582.05825564515672m, 529838.744352032940718m },
                    { 182L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f0113c08-c297-5c24-c286-8c765f119778"), "Sleek Metal Mouse", 179896.148428280561406m, 992461.327491334168082m },
                    { 183L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a967dcd6-e8f4-bf02-db04-75604848ab95"), "Tasty Metal Car", 575833.308356763952632m, 640511.040831753291206m },
                    { 184L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("a2cbf6ef-0a31-d6a0-c8dc-ddb05b103961"), "Incredible Soft Sausages", 766707.370362218443948m, 440324.676721610258550m },
                    { 185L, "The Football Is Good For Training And Recreational Purposes", new Guid("9273e659-237c-c65b-053a-8229bfb49e23"), "Intelligent Plastic Cheese", 793114.931912961712004m, 763268.46763132166138m },
                    { 186L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("3b73603a-5a7c-d9ac-9886-783b16d5de0f"), "Incredible Rubber Towels", 503439.152829429584502m, 229315.4591580644242m },
                    { 187L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("a869af37-9124-a8f7-7b4c-c0826c74cfa2"), "Rustic Plastic Car", 466054.689197026387462m, 527121.193973034568938m },
                    { 188L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("fa396f8c-271d-808d-d029-3326c59ccc2b"), "Tasty Steel Car", 793029.312218000444406m, 572955.620320158536618m },
                    { 189L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f3ba3465-1a75-46c6-477c-0b16dafa83e5"), "Refined Metal Car", 190320.6823179740838m, 405042.405047074736990m },
                    { 190L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("75418ce9-c8c5-304d-3e6d-9c8ce20ee6a6"), "Tasty Metal Keyboard", 3817.52807994345397024m, 82610.5877743494122892m },
                    { 191L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("d43643bc-4602-7f53-231b-74922d6a0b25"), "Tasty Metal Chair", 964836.822776732095526m, 249038.790048220750406m },
                    { 192L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("bbd4c484-c8ed-6efd-f276-5bd5400e1ada"), "Sleek Steel Shirt", 74713.9749538843397338m, 4983.14446650942836342m },
                    { 193L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("187886e5-8619-b6ef-5a80-5f3f9b2c19b0"), "Refined Frozen Pizza", 523121.21006442738612m, 707301.883609759571288m },
                    { 194L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7422081f-23b0-9b7c-3b9f-5054b66f45f6"), "Intelligent Granite Chips", 853503.56232347133598m, 281301.209930296936316m },
                    { 195L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("8200e7a0-426f-ad64-dd5e-b3639819f311"), "Unbranded Metal Pants", 406222.137764542583114m, 329957.500691364788628m },
                    { 196L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ef312ca9-ccb9-e98d-9c3b-8f9a16569e20"), "Intelligent Concrete Bike", 120498.129788753433010m, 561123.287129607247148m },
                    { 197L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("962d43ad-01af-ccf1-17c3-dabca7d0ea62"), "Small Metal Bacon", 383356.280080040415732m, 969532.231562005743306m },
                    { 198L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("9c545679-11d0-f035-8bec-38c43b877af3"), "Fantastic Soft Hat", 784559.2568281481044m, 791971.630698888713364m },
                    { 199L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("2927b750-e96c-d2b9-5a78-4cf935e2fec6"), "Handmade Frozen Shoes", 203915.342196262948474m, 338492.40966461670242m },
                    { 200L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("1f498c5a-efe0-9f4e-f692-9af62ebf7423"), "Unbranded Frozen Tuna", 837989.861218968599914m, 69321.1504650466887502m },
                    { 201L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("faf6f170-f24d-8da6-d32b-3400667a740d"), "Awesome Wooden Sausages", 178068.357496116736912m, 877241.834967987093668m },
                    { 202L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("989faaba-6243-544d-10d8-8dc1ba94467b"), "Refined Cotton Table", 535583.664652281360494m, 433915.914540273256324m },
                    { 203L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("19290e06-70dd-7e3f-d3e2-557901ebf46b"), "Refined Metal Bacon", 914444.615668288881644m, 624267.508036031856910m },
                    { 204L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("041f6bb8-ee44-299f-9c5b-8651fc7c6d71"), "Tasty Steel Ball", 540584.772385693889198m, 898707.513953093260568m },
                    { 205L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2a5d07dd-3464-3324-1045-c6f07bfcdecd"), "Ergonomic Soft Chair", 617586.562375495901818m, 806520.205851384213956m },
                    { 206L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("380db8f8-341f-bd5f-e35e-4f469ca326b5"), "Rustic Wooden Table", 214688.028504088241992m, 914285.861029396794448m },
                    { 207L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("284e14c1-2e34-7509-e219-328a45286f79"), "Licensed Plastic Car", 915401.548519593351296m, 686121.715950884609878m },
                    { 208L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("b15c2932-3d11-97dc-70fa-9b98412f5654"), "Awesome Concrete Table", 609117.366457415614830m, 470237.448387504275436m },
                    { 209L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("dc3a044c-905a-fda6-4ac2-8db20ee3c602"), "Intelligent Steel Soap", 390886.050566404323862m, 995048.40426110128022m },
                    { 210L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("c9a7e4be-7248-35ce-af64-567eb723e049"), "Licensed Plastic Soap", 947823.100330925042166m, 223229.5579585911668m },
                    { 211L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("965b6074-c8ff-0297-11a0-a4909bb03198"), "Fantastic Frozen Gloves", 741264.083577796786142m, 696729.358814969451052m },
                    { 212L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("9c735728-a655-ed05-8cf0-8062b20e451f"), "Awesome Concrete Shoes", 833523.48458026674286m, 240046.546411103993686m },
                    { 213L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("8b6e9e0f-c856-e13f-dbc0-5dfc339b8e74"), "Small Rubber Chair", 537794.791879982060566m, 926555.451537926698928m },
                    { 214L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2d68abfa-7d40-9f95-baed-1ab22ee5a8ba"), "Fantastic Soft Soap", 601263.790210176523676m, 608597.261674508261068m },
                    { 215L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("1046ba6e-bae8-acd4-394c-9372ed2baf8f"), "Generic Rubber Chair", 409379.154779963924178m, 8326.92899710439200862m },
                    { 216L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("34b0058d-3110-1feb-c6e0-2c9305b89853"), "Licensed Fresh Soap", 902266.395444781041638m, 430322.457867381975962m },
                    { 217L, "The Football Is Good For Training And Recreational Purposes", new Guid("95578529-3dc7-84f5-e3e3-48c2294eecee"), "Unbranded Wooden Mouse", 190384.045457839550616m, 104115.74471340411338m },
                    { 218L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("194c5d49-88fd-e8eb-1c85-3a7f17d56055"), "Handmade Cotton Car", 394054.021253867277028m, 145665.799488481362674m },
                    { 219L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("a719834b-84b4-5b44-997d-fc7a3dfb2d45"), "Handcrafted Soft Mouse", 695080.59794821377962m, 120904.83790060058248m },
                    { 220L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("83e6c54a-f952-bd3e-54e4-7b4d365b4c13"), "Awesome Plastic Mouse", 743914.497047824244412m, 161512.252239827474044m },
                    { 221L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("244d8e0e-b174-42ba-6746-59657f2cf104"), "Rustic Cotton Hat", 795445.593241504732254m, 244142.465503686424812m },
                    { 222L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("772a7092-66c7-7c1e-863c-48040bbabea6"), "Sleek Granite Towels", 746019.728716994485128m, 975483.472167177727952m },
                    { 223L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("4f516316-f5c7-7699-e08f-ba880becf129"), "Gorgeous Soft Soap", 833752.930902150181306m, 53207.0444167312419342m },
                    { 224L, "The Football Is Good For Training And Recreational Purposes", new Guid("bee6c2e9-216e-9d07-6eb6-ffab86b5389f"), "Incredible Steel Pizza", 615868.552912216700428m, 868531.954806377256478m },
                    { 225L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("8ed7c284-13c5-eac8-5cd0-f9f11b11a13f"), "Gorgeous Steel Salad", 18553.8242224276436994m, 657634.083859785742832m },
                    { 226L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("db9aa5d3-54c5-ede5-a15d-b7c123b15479"), "Fantastic Wooden Car", 882752.802755496474734m, 376370.180117097286074m },
                    { 227L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f3f68238-6377-b8f8-5b3f-5204d8ec2105"), "Handmade Cotton Bacon", 97802.9391300244314122m, 162562.672773945204118m },
                    { 228L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("ccba1063-a662-0a17-2a08-eee004298848"), "Intelligent Steel Salad", 844306.360959046853708m, 912574.659177469343124m },
                    { 229L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("3e0c23ad-5376-ab03-f01e-fd0e4207b049"), "Handmade Steel Soap", 664725.859402391290462m, 679159.523184441991590m },
                    { 230L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("f62f08e5-6db2-feca-e9f5-e75c821ac0a2"), "Refined Granite Bike", 929793.521801522219430m, 654298.117617181571932m },
                    { 231L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7ebdc9eb-da70-bfd4-4cec-0e83eadf8e87"), "Ergonomic Metal Sausages", 447976.28064606680316m, 683240.875962228110574m },
                    { 232L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("fb3e58a2-aafb-4180-7b7a-cef15dd0bb17"), "Gorgeous Wooden Fish", 445949.294200113803028m, 621789.664920009000348m },
                    { 233L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("664a70ff-d652-64ca-70ad-1193bd5815ff"), "Intelligent Frozen Salad", 178395.792212356994690m, 39432.0034240701275306m },
                    { 234L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("581221ce-8198-837c-3274-f4d858bce15d"), "Refined Plastic Mouse", 165279.572567150750086m, 457540.06039387905234m },
                    { 235L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("d31a6cfe-4245-fa76-e1b3-800244091da8"), "Ergonomic Cotton Pants", 650768.445279542365928m, 136666.157536451265374m },
                    { 236L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("744ed7f4-10e6-814d-f318-94b322ff5db4"), "Sleek Metal Cheese", 702721.201604808903954m, 865355.09778647300374m },
                    { 237L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("5c96a6e4-f720-9100-e386-d909e65ef6a7"), "Gorgeous Cotton Keyboard", 72814.2679581730299996m, 146539.267647484550788m },
                    { 238L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d280ad22-5e20-18ac-6fa9-540c4fe06427"), "Refined Rubber Mouse", 798029.564192355494648m, 859142.02564548213806m },
                    { 239L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("57811f40-8289-b3d8-59d4-d65ce97bac64"), "Awesome Cotton Chair", 491739.255922084198874m, 391892.046853157726362m },
                    { 240L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("793ff922-878e-1426-4caf-35077ce201d9"), "Fantastic Concrete Salad", 442461.988577424997656m, 583681.496678324916694m },
                    { 241L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("104fd648-d891-5764-f046-e4a704839cd2"), "Rustic Granite Soap", 392639.292927842588002m, 779238.405766413511316m },
                    { 242L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("158ec19f-c7d4-def4-7eb6-16dc227e5bf9"), "Generic Metal Shirt", 165451.188756572684776m, 599132.867881713704308m },
                    { 243L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ff3a1330-23fa-b645-68a4-a8b6704b9785"), "Small Fresh Keyboard", 85545.4086178141860528m, 893990.862034885963628m },
                    { 244L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("30515100-911e-70c9-1db3-df36817dcbc4"), "Ergonomic Granite Mouse", 150569.949923259876476m, 2152.18981153194215966m },
                    { 245L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("03017474-2987-f2bf-87de-5de79f338994"), "Ergonomic Steel Sausages", 845807.400604756558118m, 26516.3388043174297978m },
                    { 246L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("21cf9bf0-925c-4191-e88b-fdd98eac35f0"), "Sleek Concrete Bacon", 977729.819896785283328m, 295292.959341408146984m },
                    { 247L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c1e48ad5-6657-a41b-290e-c4f1bce06544"), "Gorgeous Cotton Cheese", 576084.434932702796246m, 789702.389969415249292m },
                    { 248L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("084f74c0-89b6-11a1-04cd-113a9dc97f99"), "Rustic Frozen Mouse", 801930.321783073710150m, 967124.351444404610048m },
                    { 249L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("9bc8dc94-0268-64fc-e611-df44a0fea563"), "Unbranded Plastic Sausages", 814656.341223765924586m, 339362.402166877217922m },
                    { 250L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("27769146-852d-0252-3a25-b2a8f190432d"), "Practical Soft Shirt", 221265.282418518104064m, 293041.249822322192012m },
                    { 251L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("032a7cc1-00a9-d9d4-2063-0a8245de1f09"), "Refined Cotton Pants", 227438.594460445326912m, 158428.323204520880398m },
                    { 252L, "The Football Is Good For Training And Recreational Purposes", new Guid("60017909-cd42-a8e8-9bb6-e7f2b870cc91"), "Practical Plastic Shoes", 349396.233522949370372m, 13969.4892584873089566m },
                    { 253L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("55c0dea3-48ce-19f3-1dfd-599a62f9a176"), "Sleek Plastic Pants", 656097.470235811137248m, 464741.002972213091844m },
                    { 254L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("80469d74-0bb3-887c-55c2-7936f97c961d"), "Tasty Concrete Chair", 884964.400040472058376m, 762909.254908554543768m },
                    { 255L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e562db3b-4da8-55a9-8fd6-947187ae32ad"), "Incredible Cotton Computer", 734317.26740833791238m, 802401.692903911582986m },
                    { 256L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("781e0562-5ca5-9ed1-b652-815732260ac9"), "Handcrafted Fresh Ball", 511413.163771543804166m, 681002.638878897230202m },
                    { 257L, "The Football Is Good For Training And Recreational Purposes", new Guid("98a71538-b36d-5ecc-5730-e859173f40c1"), "Small Concrete Shoes", 729827.011658939372236m, 844082.76269936826746m },
                    { 258L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("3667f751-589c-0e9d-6b97-bb2d0d6290a7"), "Tasty Metal Bike", 719534.467753552353268m, 339712.46101639911864m },
                    { 259L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("319e7be6-723f-902f-e32a-488221e748be"), "Awesome Rubber Fish", 981368.40748164955922m, 58511.833124406707386m },
                    { 260L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("131a6b6a-dde4-91e5-5f2f-1600ae37eb5d"), "Fantastic Concrete Keyboard", 459834.730069077523246m, 564270.121765011388976m },
                    { 261L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("7252762f-f814-05d1-43ae-144018f3b755"), "Intelligent Frozen Shirt", 474531.14141066905430m, 556141.265474566485356m },
                    { 262L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5fc1678d-ac26-42da-0e28-26b9c59c7631"), "Licensed Cotton Mouse", 467965.848842242452376m, 173888.819409944627442m },
                    { 263L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("34cc4339-cbd1-5c91-0db0-31d248ff6397"), "Small Metal Computer", 821697.727696583813348m, 649748.464998949007044m },
                    { 264L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("97a44666-69ff-9fde-76e5-dabd1ddc96e4"), "Handcrafted Soft Mouse", 599665.989484778365688m, 789205.469334459506890m },
                    { 265L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("84183d23-ddf8-bbcd-7275-2633b79db885"), "Handmade Metal Sausages", 830030.697370501133568m, 912397.008067220274228m },
                    { 266L, "The Football Is Good For Training And Recreational Purposes", new Guid("c7236594-0997-f2ad-5c53-026346abc16f"), "Tasty Rubber Mouse", 847772.999684751535716m, 281766.503287178361376m },
                    { 267L, "The Football Is Good For Training And Recreational Purposes", new Guid("05bfd9e7-3330-a80e-8e4a-92cc891b4f66"), "Generic Plastic Tuna", 275187.8851652289198m, 917832.62752013362588m },
                    { 268L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("4836645c-84a3-6ec1-81c1-e14ec9ac3ea2"), "Rustic Fresh Table", 718929.99885476656872m, 791033.357418617027008m },
                    { 269L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("adc4d68f-089b-9988-a1e2-c1aa39b04ff7"), "Handcrafted Wooden Hat", 579678.052880213526724m, 425622.281027320456830m },
                    { 270L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("75e8b407-3ae1-e8fd-11f7-906a14a6f868"), "Generic Wooden Towels", 863782.995610107644892m, 76762.1073369531810502m },
                    { 271L, "The Football Is Good For Training And Recreational Purposes", new Guid("b7518227-581c-0928-3cbb-88137ac16d12"), "Unbranded Rubber Ball", 223554.610308802166166m, 38357.0845029344694862m },
                    { 272L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e54cc028-261f-d8ee-66cd-2023124254d1"), "Intelligent Metal Chair", 701855.688279332016968m, 499675.350967720363158m },
                    { 273L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("183a87c3-3305-90e2-35de-fa588d2db26e"), "Licensed Metal Chips", 314427.870687738914524m, 797806.453410174951454m },
                    { 274L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("18fa371d-b99a-6fcb-1024-d215d62418df"), "Intelligent Fresh Salad", 750011.958526164897836m, 349020.09024680342724m },
                    { 275L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("b3fa0d30-414e-4a18-71ed-e871607ff2b1"), "Practical Plastic Shirt", 873972.382345940415598m, 725804.030560410661250m },
                    { 276L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("333db5ca-0808-832c-ff14-7222cd867f74"), "Incredible Fresh Hat", 622669.113235115852334m, 365198.403024934157598m },
                    { 277L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("71c17521-cfec-8484-67b8-b32f3431175d"), "Tasty Wooden Computer", 153010.47313420169248m, 193027.247638589616286m },
                    { 278L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("936856bb-67dc-104e-f60d-20ac7f3cbf4d"), "Handmade Wooden Cheese", 140846.006640938336970m, 540381.686039855393222m },
                    { 279L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("dac7d78a-5eeb-9c14-cc58-c267aafa01dd"), "Licensed Granite Pants", 672223.289302616500232m, 514191.970904848422306m },
                    { 280L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("280d4b5c-9bd6-5d8c-aa59-b56a4ecc98c2"), "Small Fresh Shoes", 654440.618470269295752m, 921453.878353220474674m },
                    { 281L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("744a9663-4d7a-52ba-90b6-a7f78d24ee5a"), "Handcrafted Wooden Chair", 71056.2574579166625684m, 847313.631891728959236m },
                    { 282L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("2ccd6b2a-3106-d4c6-d991-62fa0ea972c8"), "Awesome Concrete Cheese", 912104.876883915809364m, 429317.554536346657654m },
                    { 283L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("517ca54a-9794-01d5-2d4a-73bc4e08b25b"), "Awesome Rubber Ball", 817550.391237771320352m, 657849.771843215913218m },
                    { 284L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("7cb864d2-0998-c91c-0b2e-909d5dcfcb82"), "Small Concrete Chips", 37964.2006628711211514m, 858113.399655233233070m },
                    { 285L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("78ff1715-bf0d-a1c8-3905-5aefb78354b8"), "Handmade Concrete Shoes", 197756.047875918226390m, 350010.686683507591438m },
                    { 286L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("460a98c1-59ce-2321-4aae-1834cb859386"), "Incredible Cotton Chips", 109182.466398925475410m, 74718.7064031984221798m },
                    { 287L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c31ba6e8-7aa0-7f5e-9c6c-43c24b578178"), "Handmade Cotton Soap", 857009.996063280830598m, 230569.465676013372266m },
                    { 288L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("bc9b1dde-c39d-457e-99f4-ab494bc52e8b"), "Incredible Soft Car", 2010.51032264849664564m, 924235.638173759706534m },
                    { 289L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("65ab94a6-394f-6084-da16-0d47948b3daf"), "Incredible Steel Towels", 666627.052269596951264m, 229969.910929729263058m },
                    { 290L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5ad31d70-c632-eccc-1b9b-a73630aea25a"), "Gorgeous Frozen Sausages", 440232.858059619949806m, 787232.419683872700278m },
                    { 291L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("58ead5e9-01f3-f824-bc59-7f64ee2756b4"), "Awesome Steel Soap", 863918.872300724720150m, 658055.291708783360002m },
                    { 292L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("b65d0ad8-c503-01b3-a7a5-fb222e11d042"), "Ergonomic Plastic Computer", 493998.96515484369450m, 716227.635415162257404m },
                    { 293L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("8e8c8051-c53f-0134-3fd8-fcabf1de185d"), "Sleek Rubber Pizza", 533936.642921106410944m, 472939.683547184147114m },
                    { 294L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f7e8efe5-a28d-8a93-b0e9-3ec6138c90cd"), "Handcrafted Cotton Computer", 280743.702936894153154m, 246599.704112901377408m },
                    { 295L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("c8c5870f-2789-2ed3-1303-2348ad9b46b6"), "Incredible Cotton Car", 714375.629652445190876m, 548972.599321278466654m },
                    { 296L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("ff98f693-d6ab-2780-ab69-715bb5f661f6"), "Gorgeous Steel Pizza", 420920.484657264004166m, 123385.84165514314936m },
                    { 297L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("a1e225ad-d2b7-9164-272d-8cf19f54fe40"), "Licensed Steel Chair", 900922.376028636250016m, 863827.31871602725576m },
                    { 298L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("3ab5f44f-8e5b-13c0-1af6-0b53fa9054e7"), "Practical Fresh Hat", 90556.840512425751062m, 253992.421331047370188m },
                    { 299L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("0f80be2e-40e3-f73a-e8bc-6f2fa3b46711"), "Awesome Rubber Mouse", 867278.968685908509370m, 345163.891848334649002m },
                    { 300L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("b3ac8211-bf6f-43a5-2cba-1fa072ec1ced"), "Generic Cotton Chicken", 610188.732675306893574m, 718168.80468419795464m },
                    { 301L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("1a68bb0b-47d4-2b90-0c47-20b8a20bcf18"), "Gorgeous Rubber Cheese", 29168.8261194097896426m, 489043.859839485145678m },
                    { 302L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("995cc635-9760-b13a-80a6-37c7788efe2e"), "Unbranded Plastic Keyboard", 944038.396756752329356m, 913347.289436608734318m },
                    { 303L, "The Football Is Good For Training And Recreational Purposes", new Guid("57527511-5caf-ffaf-b3e0-d270c706de7a"), "Sleek Soft Mouse", 755412.987212647920712m, 902651.602758726872914m },
                    { 304L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e14ba7a0-0d4a-14bd-77cf-a1353bc9a7d1"), "Fantastic Cotton Tuna", 488298.125689458428674m, 281919.119136220052828m },
                    { 305L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("5172d19d-5838-6951-19ea-d4a9b3da5d3a"), "Licensed Granite Chicken", 154822.507686814339102m, 551314.980299182141304m },
                    { 306L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("256f602d-86f4-f130-b562-52b7fc7f95d9"), "Small Fresh Ball", 925743.874908739203616m, 754708.620497836167808m },
                    { 307L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("bc732809-3344-5246-5874-1b0bb1d97ef7"), "Practical Metal Towels", 38325.3521049836923176m, 526377.470790935908034m },
                    { 308L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c0fbb267-4589-ed11-c8af-2a074e1a6dba"), "Practical Cotton Salad", 46818.4824931554433846m, 102004.21450555297522m },
                    { 309L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d91c8e12-55c8-3356-f148-95ccd610a625"), "Tasty Plastic Shirt", 113893.000233624963838m, 15416.563765594806432m },
                    { 310L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("61e15ee2-0cb9-314d-e6d3-506a329013a1"), "Small Concrete Towels", 909485.684275308503370m, 904093.520145610331466m },
                    { 311L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("92429064-ff77-78d2-4dd8-99518e6f5706"), "Ergonomic Steel Sausages", 178877.438276653939508m, 912295.260386134043392m },
                    { 312L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("07469753-36a7-be4d-3949-a55afc49d97d"), "Refined Concrete Fish", 503846.376821522971416m, 39940.1127199759032778m },
                    { 313L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("cefbeb65-04fe-2738-71d9-e01a74cf3026"), "Fantastic Fresh Soap", 205095.535998886622442m, 77047.1730639730867452m },
                    { 314L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("d8bc1df5-a5c6-edbf-952c-0916674114cc"), "Generic Metal Gloves", 97132.5717485821757716m, 754403.071427220531238m },
                    { 315L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("68446a48-c486-23e9-16b5-0c78e71ba80e"), "Fantastic Steel Pizza", 676614.886031218476606m, 385184.79068629788916m },
                    { 316L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("c65d249e-e082-da5d-5dcd-364ebe170075"), "Ergonomic Rubber Car", 990777.208175313536614m, 468608.207381553804314m },
                    { 317L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("d4ffa833-5fd9-e5f0-3bf6-91742b8a8b21"), "Sleek Fresh Keyboard", 706663.26589233156062m, 477077.4349464217976m },
                    { 318L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("7447866a-70c1-9b09-2b74-64599f4d515f"), "Ergonomic Frozen Bike", 535799.270693908414814m, 905321.18474653921894m },
                    { 319L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b3f7825b-86fb-b080-f33a-c26ffad6f5bf"), "Intelligent Cotton Table", 328245.687784807449008m, 973807.369888837989054m },
                    { 320L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("f9424089-db77-2755-b847-5bb718162f75"), "Licensed Fresh Towels", 382858.166061888444496m, 560670.66070599590488m },
                    { 321L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("4647dcac-4fab-a2be-b382-66485aa79be4"), "Handcrafted Cotton Shirt", 692258.889566332830238m, 661537.036784091282378m },
                    { 322L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("355d58d2-dbb8-0c13-df2a-0f879b82f234"), "Intelligent Plastic Pants", 491690.3909819512746m, 811536.912074302701254m },
                    { 323L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c3f41283-7173-2510-b2fa-dd1e9e03aee1"), "Practical Concrete Pants", 380654.46715298307712m, 606875.363708488080714m },
                    { 324L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("525a4512-2efe-da7a-40ec-908b24a34e08"), "Tasty Granite Chair", 381207.084783187606236m, 628115.186698721140786m },
                    { 325L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("232a4ae4-2733-ecfb-f738-2e16c1e625c5"), "Gorgeous Wooden Bike", 899074.957917303862368m, 639331.367356538960338m },
                    { 326L, "The Football Is Good For Training And Recreational Purposes", new Guid("4fd80838-a0ab-e346-7334-369169a16ea6"), "Fantastic Granite Chips", 876538.118081418681678m, 287994.156286307452456m },
                    { 327L, "The Football Is Good For Training And Recreational Purposes", new Guid("e56942c1-3a4f-601d-1982-289bc6c30ecc"), "Awesome Steel Computer", 276055.563490071799394m, 418510.785493808969892m },
                    { 328L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("fe9d0dac-f8b1-5ab4-ba36-ad469746c278"), "Tasty Granite Soap", 241650.213289019823174m, 425901.206257537880692m },
                    { 329L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("d9a47b02-ad1f-413f-6ca9-859926b9f2a7"), "Tasty Cotton Pizza", 675664.007131305079956m, 775747.113853170302998m },
                    { 330L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("f2a74268-b3e8-3501-ee19-0b9faf81de76"), "Refined Plastic Sausages", 566924.782587084126166m, 278730.146036359008468m },
                    { 331L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("a869ee9a-0b9f-fe2e-df1a-55ae296e4d54"), "Awesome Concrete Shirt", 502074.381498203706050m, 834352.768434522717206m },
                    { 332L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("53701a87-9305-8972-7103-47595b939340"), "Handmade Cotton Ball", 597852.559587863413252m, 676601.430375207842450m },
                    { 333L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("3bd7f4d2-ce5d-43dd-3055-1de192cc5cea"), "Practical Granite Bacon", 928130.314809903855508m, 126321.714531230653670m },
                    { 334L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("1ff76962-b2b7-bed6-fb70-04acffe3e47b"), "Intelligent Granite Pants", 399324.375809263084776m, 211845.638844772930204m },
                    { 335L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c16fc8cb-e16b-906a-d823-3d257b71b293"), "Tasty Fresh Tuna", 300435.243724502811616m, 733880.316511759453344m },
                    { 336L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("a6d5a404-b0eb-f388-75c9-eb0c83c7da43"), "Rustic Concrete Computer", 741948.223397308410554m, 360369.077701679121448m },
                    { 337L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("aa5bed92-f22f-6e5b-2b29-3c7c92aaffbb"), "Incredible Cotton Bacon", 148222.233944490224898m, 372046.603428302958004m },
                    { 338L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("d288c99f-9446-8822-c974-dae68eec90e8"), "Handmade Granite Shoes", 864834.105672391315876m, 339313.06119026036852m },
                    { 339L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("479512d4-e720-bf65-1a21-4a677c9bb339"), "Gorgeous Steel Towels", 508.717089375662376256m, 455783.072085038697988m },
                    { 340L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("00b697a8-d909-c756-67c6-f150b4914785"), "Generic Rubber Shoes", 242294.287366553091806m, 78044.1770846114574444m },
                    { 341L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("146d7760-41e7-04c5-400a-aa49d7739e99"), "Incredible Plastic Bike", 302608.081101329366596m, 237594.655251637120204m },
                    { 342L, "The Football Is Good For Training And Recreational Purposes", new Guid("d411ff66-aff0-f529-a9eb-37101e1cf7e9"), "Handcrafted Rubber Car", 219618.03928436296136m, 113300.571042111716586m },
                    { 343L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("a1963c43-8d8c-e8f4-48c5-fc2b560229cb"), "Practical Concrete Salad", 20829.6378731465389888m, 832977.60183369441954m },
                    { 344L, "The Football Is Good For Training And Recreational Purposes", new Guid("c04049dd-ba7d-693a-f79d-478cb8858977"), "Awesome Soft Table", 385726.171464661166906m, 19907.5584451509833050m },
                    { 345L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("34df1caf-1b29-b87c-7655-52fbdd066413"), "Handmade Plastic Shirt", 596045.975588125639078m, 608728.111293394499896m },
                    { 346L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("43f3d0b6-3186-70c7-4297-bcdbf9605b24"), "Tasty Granite Mouse", 417754.703461445058954m, 14481.8644116799530666m },
                    { 347L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("9dc15566-400e-c2a7-e079-8f3e7ac648b9"), "Sleek Concrete Chicken", 484839.606946427748838m, 695245.113415801186382m },
                    { 348L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("e878dc43-956b-f865-8d55-e49cb2297ad9"), "Practical Cotton Chips", 152195.71820126481738m, 663673.229639580026612m },
                    { 349L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b28852f2-45c1-a10b-f141-4936a7044e40"), "Tasty Metal Ball", 474688.600959010327778m, 250848.196821481966242m },
                    { 350L, "The Football Is Good For Training And Recreational Purposes", new Guid("09ff4720-8c72-176b-9a14-27facbe7b319"), "Practical Fresh Bike", 348140.302782013875976m, 736089.321744504151816m },
                    { 351L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e9e5e082-11dc-52f8-961e-2e032bca518e"), "Handcrafted Frozen Table", 647339.177891213859682m, 868793.976665996489150m },
                    { 352L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ada9c788-7ffe-f2b8-ad14-cd2104c226a4"), "Ergonomic Wooden Computer", 969839.230148675341970m, 672556.147237741298548m },
                    { 353L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d9cfcc53-5ef8-9222-5575-029ebc35b0d2"), "Refined Concrete Computer", 72361.0192463927665586m, 204098.070885288839506m },
                    { 354L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("9b81ad82-58fc-144a-2aa2-263589668332"), "Fantastic Fresh Salad", 343921.511770907773386m, 659385.481316743823312m },
                    { 355L, "The Football Is Good For Training And Recreational Purposes", new Guid("fd801301-a16a-b3d4-51ce-4125e91097a7"), "Handcrafted Rubber Sausages", 928072.117074947558212m, 398857.205215052141884m },
                    { 356L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("9e025cf5-031c-6f9a-4937-d5c348de53ff"), "Sleek Plastic Computer", 744126.089370281753126m, 750852.794983891619030m },
                    { 357L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("a0990dcb-f241-a80f-3aaa-821f755badc1"), "Incredible Fresh Salad", 908760.306799735356032m, 603268.284862300201434m },
                    { 358L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("e5c51a0d-4075-c500-191e-c6b9b7ea5501"), "Unbranded Concrete Bike", 194602.071470097653962m, 204988.237501560046290m },
                    { 359L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f3c8b3bc-bfc6-f2c3-950d-cb9f9e828317"), "Intelligent Rubber Chicken", 886058.549308989144736m, 533100.313258609081264m },
                    { 360L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("45dd8838-c945-5288-2b13-9e89ef1eb27d"), "Refined Plastic Chicken", 531722.983429992247828m, 479592.28310523542056m },
                    { 361L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f0b01107-0ad8-fee8-cbe9-e7b336674000"), "Awesome Fresh Chicken", 5434.51805944887698654m, 292393.77972840096974m },
                    { 362L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("496795db-fb58-6437-4802-7a0040b3785f"), "Refined Soft Hat", 585627.715248558991336m, 578632.056565139340866m },
                    { 363L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d09edf95-3d68-1cb7-482a-ae8476cab319"), "Incredible Concrete Chicken", 630747.96934006832694m, 835809.104238472283952m },
                    { 364L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("ff8d1191-f9d4-f270-676a-fa6a60d05851"), "Unbranded Frozen Mouse", 724711.696610316930782m, 584434.340070078121808m },
                    { 365L, "The Football Is Good For Training And Recreational Purposes", new Guid("435684c4-5792-8fb6-44e9-b05d30d5f769"), "Rustic Plastic Computer", 120453.542620171948522m, 158055.563212588355306m },
                    { 366L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("e1a08000-b85b-7cc4-46a9-c425aa434525"), "Sleek Cotton Towels", 680698.780675061853308m, 240540.150541347758778m },
                    { 367L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("993cb4aa-cd35-54be-9781-f61637dacb4e"), "Intelligent Soft Chips", 20542.700008398816238m, 745058.905896154970106m },
                    { 368L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("3bbed112-eb3f-c245-418e-dfde90aa6e1a"), "Licensed Metal Gloves", 910207.197685140797646m, 35279.4145634851590892m },
                    { 369L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("032f27d5-f95b-1a5f-74bd-80c2cf8d8b87"), "Gorgeous Wooden Tuna", 197544.421800307224118m, 821438.802836612568992m },
                    { 370L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("5b175399-b57e-f02c-fa2c-0aa29d3968f4"), "Practical Frozen Pizza", 480511.517717814518456m, 709414.575523519292984m },
                    { 371L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("fad67829-70d5-4039-6d3f-60b83a631efd"), "Rustic Steel Chicken", 330252.001623813745724m, 514456.799107701957284m },
                    { 372L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d7e0f77b-773d-d4fd-221a-c1c2760e877a"), "Incredible Wooden Towels", 811705.116023835129372m, 261849.246675257254404m },
                    { 373L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("fddbe7c3-c755-f5c7-affd-dc3a3f75ddd8"), "Handmade Rubber Bacon", 543859.972759674040410m, 638372.95568431513844m },
                    { 374L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("fefc1346-4efb-3000-c025-c99720b5c808"), "Refined Frozen Shoes", 631882.014359577751732m, 841329.418217823243950m },
                    { 375L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("e92f0161-b850-beb1-1e64-8ac78b521532"), "Licensed Steel Chicken", 276119.697879708763582m, 178866.651815424905112m },
                    { 376L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("102a0e6c-9f6b-bb8c-3608-e98475520928"), "Practical Rubber Keyboard", 154043.677960569906916m, 803450.566397398400510m },
                    { 377L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e38c2728-2b2b-c8a1-0858-0380f88cfe23"), "Practical Frozen Car", 710829.753394278890742m, 176824.261752280200978m },
                    { 378L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("89c73273-54b4-f659-5b12-8978c90227f2"), "Unbranded Plastic Fish", 307682.33114641697938m, 331632.525797156876930m },
                    { 379L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("f5d9021f-8bd0-289c-9784-1153a2cf282e"), "Generic Metal Chicken", 707711.578680458791106m, 605847.007651422308278m },
                    { 380L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e52b88c8-31b5-b0a9-3f26-03b9dc0a84bf"), "Gorgeous Frozen Soap", 921485.657135352783294m, 345664.669515074312408m },
                    { 381L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("87fea6a4-13b9-5586-ade9-53dd66ebe3b8"), "Refined Fresh Gloves", 44912.9433448135622402m, 21416.6375399640573504m },
                    { 382L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("fbd60128-95b7-8337-2830-baf26ac3b4b1"), "Intelligent Metal Pizza", 109346.474531858553510m, 543599.902917803764432m },
                    { 383L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("18d8d476-0dd6-8d45-e0da-f28429769566"), "Ergonomic Granite Soap", 100181.344565603146614m, 332089.382537173569466m },
                    { 384L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("487babae-1756-30db-1464-bbd9f6705081"), "Practical Metal Keyboard", 779475.337148400799614m, 480597.610482409644894m },
                    { 385L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("1a62a3ab-1bb3-44e8-863f-693599e9e5c8"), "Awesome Fresh Bacon", 329604.721670753240970m, 561949.081595775011628m },
                    { 386L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5cf747f0-080f-e2b2-e2ed-0ed1162b986a"), "Handmade Soft Sausages", 524970.620565712985892m, 107000.121616063770530m },
                    { 387L, "The Football Is Good For Training And Recreational Purposes", new Guid("0a525b28-2e47-a4f0-1833-2666c8a3718e"), "Generic Wooden Shirt", 938042.902421414982056m, 879600.26741242677104m },
                    { 388L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("758d0374-1a68-8ee9-3cf6-67f28bfeb493"), "Handmade Cotton Pants", 979038.040437883968238m, 63388.6465585540317986m },
                    { 389L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("9444ef82-3be5-1877-b1ab-7f03f06d9af3"), "Intelligent Fresh Shoes", 189914.578655529033108m, 107224.126206037694562m },
                    { 390L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("539b2850-dcaf-5155-cc45-cf99950fd008"), "Handmade Rubber Ball", 806516.746368100194362m, 424248.549884916236574m },
                    { 391L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("87385bdc-ea08-4564-6f18-1818237ab707"), "Incredible Metal Chicken", 969393.326137381148178m, 752403.038563089259648m },
                    { 392L, "The Football Is Good For Training And Recreational Purposes", new Guid("235c8fe8-c036-33b4-c965-7b4ca9214459"), "Refined Metal Hat", 752512.904965189015982m, 450925.219962321374870m },
                    { 393L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("dd5404d0-3550-0565-5944-9e1b56412ef3"), "Intelligent Plastic Pizza", 938368.176013969495850m, 201094.005939231747904m },
                    { 394L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("eceada08-1e7d-a791-e42a-da9bc0c235c5"), "Awesome Cotton Bacon", 320865.519812441914470m, 892569.768071469574848m },
                    { 395L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d3861bfc-8b50-06fa-8faf-9775f70a9094"), "Unbranded Plastic Bike", 189035.371050846759310m, 326649.706211838978884m },
                    { 396L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c657d9c6-8617-01c5-a472-fed87fe2bbfb"), "Practical Fresh Bike", 757864.511934067671754m, 437077.504549564591356m },
                    { 397L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("3d7e3368-2184-34bd-7934-56401befb8ce"), "Unbranded Wooden Car", 39316.7959258143848730m, 722110.770246785061572m },
                    { 398L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("475fc9eb-688f-ef81-a932-92c02d4f0d94"), "Licensed Rubber Chicken", 736532.686558146751068m, 10764.120333481280470m },
                    { 399L, "The Football Is Good For Training And Recreational Purposes", new Guid("d35da8d5-3918-fb90-c81b-d467b01aef62"), "Incredible Metal Soap", 574463.910675185793390m, 963770.526332044250096m },
                    { 400L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8148c252-bad9-40f9-2e54-9c5f0668d629"), "Rustic Granite Shirt", 532899.928688964022094m, 659770.800831341252836m },
                    { 401L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("c62a7694-b6cc-c211-0e87-981c545c0ac6"), "Refined Wooden Soap", 267717.133569292994738m, 681091.122022385589292m },
                    { 402L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("6f3e91be-114c-fe71-7b81-9454bfa85258"), "Incredible Wooden Gloves", 309897.788804965800434m, 589155.342989785398344m },
                    { 403L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("95dc27dd-504a-667b-17ac-c51bb6fbffee"), "Small Fresh Shirt", 351204.33465754586876m, 211640.485964070512222m },
                    { 404L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("f3dcba4b-fad8-decd-27c4-5e4288b75226"), "Fantastic Soft Computer", 566129.948830809818056m, 739315.955350979032306m },
                    { 405L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("a099096a-36e5-fd0b-a4cc-05e6fc69d8ad"), "Fantastic Granite Keyboard", 414077.587143217403904m, 726490.682619984795488m },
                    { 406L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("eb312c42-b6c9-c946-26a8-c95e83c974d1"), "Licensed Rubber Sausages", 827929.075348550583974m, 257977.074011687070266m },
                    { 407L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("cbbffa26-6e7a-d073-8f8e-decdddf99222"), "Gorgeous Steel Chips", 84469.1883642018981670m, 617995.46815433170852m },
                    { 408L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("cf8619c6-6928-a4e1-66df-2f4424bb2ca9"), "Fantastic Steel Shirt", 877197.476831306544462m, 646781.969630676609594m },
                    { 409L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("64bc0684-c3e1-116a-bdc7-85af4f19f7ea"), "Licensed Metal Bike", 164359.696874053815790m, 909378.169380994722058m },
                    { 410L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("3655144d-ac29-92c2-9f08-e7fd22f83499"), "Tasty Granite Tuna", 330716.642706680721422m, 565971.396957718198448m },
                    { 411L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("35a5c9d8-2051-eb44-ba79-df8c73acf1fa"), "Unbranded Frozen Ball", 868947.31831594757588m, 332349.615713613175652m },
                    { 412L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("10af6364-8aee-13f4-8c84-6630960b99ab"), "Intelligent Granite Computer", 308279.784417192048012m, 504280.742555135766724m },
                    { 413L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c6a33ed9-9c37-9db8-fb06-47c3b6c47a3d"), "Tasty Frozen Soap", 12092.3456408069529068m, 354217.653497368135816m },
                    { 414L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("3e1b4721-037e-44ca-853d-0bf3ef6fbe06"), "Awesome Cotton Shoes", 805540.142462389912206m, 318845.006237611146202m },
                    { 415L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("592290e9-ae1c-6101-ed75-857606184935"), "Tasty Concrete Bacon", 842722.836222478660956m, 221048.388862475083726m },
                    { 416L, "The Football Is Good For Training And Recreational Purposes", new Guid("40999375-bac0-ac9f-c431-0e259f1ee061"), "Rustic Granite Sausages", 78687.6730049676427432m, 553152.268808343773812m },
                    { 417L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("8c972511-59c3-b1b3-34ab-2e8d27b20f98"), "Ergonomic Cotton Shoes", 278949.004153802898146m, 845960.072737794681352m },
                    { 418L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e36a93a9-0616-031d-8bc9-89a259f2f936"), "Gorgeous Granite Shoes", 144751.183337499323110m, 639756.702748502475066m },
                    { 419L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("012286ab-c320-4a25-5a7c-7b2fae0ae31a"), "Ergonomic Plastic Chicken", 892671.293743009825664m, 984831.232227285216622m },
                    { 420L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("cab12455-b204-5658-66d3-ec3992a6d655"), "Handmade Cotton Table", 548224.334830822440630m, 824811.535335266080728m },
                    { 421L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("55771992-42c6-5210-3bf6-157df46bedf5"), "Fantastic Fresh Car", 209584.039031792602582m, 34770.0163017585201396m },
                    { 422L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("3898d8e0-b796-63df-b4bb-c19c20d68aa6"), "Practical Cotton Chicken", 410012.861767898413476m, 436564.457874375993924m },
                    { 423L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7c6f319b-3874-111c-5635-f889511f55fb"), "Rustic Soft Fish", 953991.437841200348216m, 393119.889259411002476m },
                    { 424L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0f0aa65f-8ed4-c700-fdd2-092595614caa"), "Gorgeous Wooden Shoes", 363020.584909473099810m, 955495.821598837815394m },
                    { 425L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f9dda541-c9ff-a249-c3d8-c8932d295517"), "Ergonomic Cotton Ball", 164137.900196628057830m, 829223.718667904766682m },
                    { 426L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("fafaaeba-5a31-a026-b2e4-63de707ada4f"), "Practical Cotton Car", 264068.344557182614144m, 656870.60739808772014m },
                    { 427L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("31b00de1-5819-30bf-a6bf-d651069a6f11"), "Awesome Wooden Ball", 749680.472803367669376m, 642394.554862526695588m },
                    { 428L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("66c146b9-f698-e730-bd9d-e5e0aa462062"), "Generic Granite Tuna", 837532.177420829026932m, 257492.032617758798292m },
                    { 429L, "The Football Is Good For Training And Recreational Purposes", new Guid("bd3ec420-f0bc-3eff-a996-549c14196960"), "Tasty Frozen Shirt", 309444.665593063036736m, 527446.378462249289768m },
                    { 430L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("432c4887-005c-9e64-f9b8-b17276e68f10"), "Sleek Frozen Computer", 94012.6432751695023358m, 637225.605132252831976m },
                    { 431L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("33aa232a-719b-4bd8-3ad1-3e697f63dd40"), "Awesome Fresh Tuna", 384168.341588329150902m, 852446.17706194608858m },
                    { 432L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("9305d2f1-9683-410f-1f78-cd1fec490686"), "Sleek Cotton Sausages", 721913.426858995626526m, 533879.665526079428908m },
                    { 433L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("401a8001-e9d0-c545-6262-1a74de7413d4"), "Ergonomic Fresh Tuna", 99891.6186424838517586m, 231048.63444343692074m },
                    { 434L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c886b64a-0699-0401-3592-71f34abc89c0"), "Sleek Soft Tuna", 886148.11225631089184m, 247663.791874926596998m },
                    { 435L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e4493316-168d-8654-8dc1-d67c085689dc"), "Licensed Concrete Bacon", 748560.303188138380522m, 446998.303496421014368m },
                    { 436L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("3cf67cfb-ba7a-c0d3-d20b-229284bf6cd8"), "Handcrafted Plastic Computer", 97137.3616423004691754m, 281827.437641014409966m },
                    { 437L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("cf39dc3d-dbcf-6365-5d66-eea9b04a38c7"), "Gorgeous Frozen Pizza", 567114.615729945081110m, 484345.268071312476428m },
                    { 438L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("d657e47c-e0a7-2688-38eb-aa7cfc475b6e"), "Intelligent Metal Gloves", 959527.664552895779874m, 71340.5161703867005912m },
                    { 439L, "The Football Is Good For Training And Recreational Purposes", new Guid("313cdf8b-88d9-28a5-b96e-2f22e2937a57"), "Refined Plastic Hat", 600510.283136614684834m, 421485.610357287343612m },
                    { 440L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("303ca424-6b0b-43c3-5286-c2f0ee58de9b"), "Handcrafted Wooden Towels", 12226.3195299382387476m, 894209.364010044139302m },
                    { 441L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("4d47241d-5a41-cb8d-aff0-a91aeb1ff832"), "Practical Fresh Bike", 523957.063801677568198m, 451493.384096711833428m },
                    { 442L, "The Football Is Good For Training And Recreational Purposes", new Guid("e9a99d78-71f0-cf28-2b3c-daac25cd46ee"), "Practical Frozen Bike", 156627.60614120120992m, 79757.4916292656148642m },
                    { 443L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("536b3ef3-14e6-168e-a202-5abcb07f2775"), "Unbranded Metal Pants", 361094.591983000656742m, 934990.474956019122582m },
                    { 444L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0bafc523-9e5a-224b-5707-649706762d9f"), "Awesome Wooden Fish", 794258.38380441535528m, 707920.051371738574654m },
                    { 445L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("dc164cc3-6601-e1be-f562-a7837cf25566"), "Licensed Rubber Chicken", 223274.209923704057966m, 831625.23293456762728m },
                    { 446L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("107227d7-9ce7-40d4-89ed-ecaf8d4e5456"), "Handcrafted Granite Pizza", 376024.89379278831584m, 627955.304729323719110m },
                    { 447L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("43c2fa0d-d1f7-d2a5-ee02-17816ee8dc35"), "Tasty Cotton Bacon", 545484.711322591415608m, 370901.119880527635498m },
                    { 448L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("bb69d7af-99a0-b835-2c7d-1769d37c9f4d"), "Gorgeous Rubber Sausages", 784822.23731971606934m, 868300.229277683240770m },
                    { 449L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("14af5641-1150-2233-6811-17cad763eb47"), "Sleek Concrete Bike", 397292.213522466787034m, 881744.083705644609322m },
                    { 450L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("43a463e1-63b2-5ee9-12e2-b77d970d7084"), "Incredible Cotton Gloves", 529400.564893164611176m, 322738.870290850464236m },
                    { 451L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("335b9fdc-1388-83a4-d5c9-cb0a1b3fb39e"), "Tasty Cotton Bacon", 172.336849336960977310m, 636338.124888600869208m },
                    { 452L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("27178387-b471-1dbe-5f45-05b0e6d18612"), "Refined Rubber Table", 359449.21041299137830m, 379205.490644063890876m },
                    { 453L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("bfe4638b-c9de-5b7d-3eec-e652e29a1307"), "Rustic Steel Fish", 471660.566460659436642m, 986185.933986430279514m },
                    { 454L, "The Football Is Good For Training And Recreational Purposes", new Guid("cc2592cb-7b27-fac7-c871-1674558faa89"), "Fantastic Cotton Sausages", 601303.653087991608594m, 600641.95634259474618m },
                    { 455L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("524840f5-6b24-7aa6-d093-83fea413719f"), "Small Steel Computer", 752185.253684615887736m, 174498.456544903918970m },
                    { 456L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("5b267592-b228-76c1-3b45-8f462e710815"), "Fantastic Soft Keyboard", 311839.188013827617098m, 950570.139058044599750m },
                    { 457L, "The Football Is Good For Training And Recreational Purposes", new Guid("4176a1cb-ab7c-e345-6bf3-2739172c9af9"), "Small Concrete Salad", 624767.339321176287292m, 333678.346391047505850m },
                    { 458L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("50b803a9-a314-175f-0654-8993b108b476"), "Practical Concrete Pants", 238385.955743303971662m, 8383.69098252764411372m },
                    { 459L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("b576cbb1-5592-100b-b404-f4e45b8e1b50"), "Fantastic Plastic Fish", 163710.53839957836138m, 588441.551822184588716m },
                    { 460L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d16d3f2f-de8a-6e60-47de-4de06b076122"), "Ergonomic Frozen Chicken", 363796.19604806272018m, 848779.515969899939346m },
                    { 461L, "The Football Is Good For Training And Recreational Purposes", new Guid("902871e1-ec50-a821-3667-0458a549704d"), "Intelligent Plastic Soap", 848217.392189134749376m, 961410.428137369079858m },
                    { 462L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("6557d81b-7b0a-56aa-ef61-7d21eced4e10"), "Fantastic Metal Table", 247679.20924655079208m, 657000.419533800929464m },
                    { 463L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("928f7a8d-1478-5717-f2f0-24b29af16c7d"), "Fantastic Steel Mouse", 679932.271434503400468m, 620475.461978255140678m },
                    { 464L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a2017385-3486-081a-6321-c6ee57a48a31"), "Gorgeous Wooden Pizza", 672676.959939387412004m, 835387.112163600121668m },
                    { 465L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e9cdf3e8-f285-e0db-f94c-4afcea5b6a2c"), "Licensed Frozen Soap", 28588.7401792457903190m, 189489.52145893912652m },
                    { 466L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("1bbec65a-2648-d9d6-77a4-9a2bb1c774a9"), "Ergonomic Rubber Table", 381465.247339911460136m, 131683.168742092786086m },
                    { 467L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("1260df78-d01f-c5ad-b06e-d1b971c057c3"), "Practical Cotton Chips", 409040.292743033353490m, 128940.71599462225086m },
                    { 468L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("31f04ac6-a48f-4e2c-028d-00dd95e79213"), "Licensed Rubber Tuna", 571659.678871738617234m, 246232.939086755896762m },
                    { 469L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("a4a48a1e-4fe5-e5f7-b1e3-f0c87ce55b37"), "Refined Granite Table", 250197.90254093412852m, 224295.292675311470412m },
                    { 470L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("27c1b7f0-cb5c-eb53-c5ee-951b2f44b5bb"), "Small Steel Shirt", 462329.651786204109286m, 601294.500656101508984m },
                    { 471L, "The Football Is Good For Training And Recreational Purposes", new Guid("527c8cde-9083-92e3-d573-0374b26c4124"), "Refined Steel Cheese", 472065.102175134389546m, 379677.680266032758176m },
                    { 472L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("6d4b0da4-6056-8398-eeaa-258a1c8dad37"), "Handcrafted Wooden Towels", 204340.414574319492068m, 829377.093751360986268m },
                    { 473L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1eb62c53-f087-ec44-e46a-da5f1d51e556"), "Tasty Granite Car", 570240.071075402888348m, 647702.4928986233916m },
                    { 474L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("979d0e4d-d14d-daf0-a39e-f27ce92ecb9b"), "Small Soft Fish", 446304.646213234355376m, 365622.926429436650496m },
                    { 475L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("8277fe50-fde1-bd9b-2c29-bb94dc9abaf2"), "Rustic Steel Chips", 639712.813242375662878m, 726470.909138932836686m },
                    { 476L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7f660a57-5f2f-10df-4d9d-7603a83e747a"), "Intelligent Cotton Gloves", 139754.295522884939930m, 614492.834920684186376m },
                    { 477L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("dc6c577d-e8e5-8aa7-9811-e08df262118c"), "Ergonomic Soft Salad", 790540.745531787771118m, 376768.054059901808966m },
                    { 478L, "The Football Is Good For Training And Recreational Purposes", new Guid("ccb7e1ae-bfb9-9dd6-d4bc-302bfddaf06b"), "Sleek Cotton Bike", 29616.5876002439369248m, 899104.632042925492428m },
                    { 479L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("3fcbad11-5c6c-4a31-469c-f45d1194d3fb"), "Gorgeous Metal Towels", 525120.8734698525766m, 469124.889824018852650m },
                    { 480L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1fa61b7f-8eb9-1fcc-eac0-c44dfe08674e"), "Awesome Cotton Bike", 739429.739790440698244m, 407222.901838393432348m },
                    { 481L, "The Football Is Good For Training And Recreational Purposes", new Guid("e04738eb-e0ab-1c82-a375-4ff05a1c4b29"), "Handmade Cotton Tuna", 138847.937531252548634m, 527616.716674095184722m },
                    { 482L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b7b522fa-24b0-d688-e728-995efac2963a"), "Ergonomic Soft Chicken", 887074.812602582492488m, 633321.653106219499882m },
                    { 483L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("018d6fbe-8afb-e645-7829-1a38aa5d1298"), "Awesome Plastic Shoes", 331447.492233256744866m, 384586.336765450124676m },
                    { 484L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("06f5830b-0506-c0e5-9c45-0af03149ce67"), "Tasty Cotton Car", 927517.677969384987098m, 263420.20901659828786m },
                    { 485L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("abb5e85b-71a8-db98-686a-1e2199acef45"), "Gorgeous Granite Towels", 365485.782488609080728m, 153418.36260783111366m },
                    { 486L, "The Football Is Good For Training And Recreational Purposes", new Guid("0f4da47d-9c4d-ad73-9916-317ca9ee5438"), "Handcrafted Cotton Sausages", 481642.928900350627730m, 993416.5229485804328m },
                    { 487L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("7b890369-852e-4042-687b-f4fa83d45920"), "Awesome Granite Salad", 113496.703112265791748m, 606737.126637160776318m },
                    { 488L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("61f12bb1-08ce-de03-c65b-ca4e62e553e4"), "Generic Cotton Chips", 795420.699751360812116m, 12865.2001779824871314m },
                    { 489L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c255aefa-75e5-9091-a415-f344d6f29198"), "Handmade Cotton Mouse", 475529.405525750831072m, 175706.368083196010730m },
                    { 490L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1fa38509-486d-b61a-a42b-c647226985ec"), "Refined Concrete Chicken", 291705.43647843022306m, 90636.3651554532469078m },
                    { 491L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("3aa0810a-37f4-e664-ee71-b01aba7c8204"), "Refined Fresh Mouse", 90250.6820204308596882m, 593829.705714074252278m },
                    { 492L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("0d2ed658-0cb2-7a4c-2d53-bac387e5c134"), "Incredible Granite Sausages", 314369.198451542621606m, 868207.311489510188788m },
                    { 493L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("42523ba3-20eb-ee9a-79bd-e6ac0aa78de2"), "Ergonomic Wooden Shirt", 767747.732006831993266m, 928937.387006663233694m },
                    { 494L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("0aef6985-7fb2-17e4-483d-824bcbb3f735"), "Gorgeous Soft Salad", 548692.494561899105834m, 557856.229337021900576m },
                    { 495L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c98d6dd1-1be4-187a-5d86-306ce5d6d800"), "Ergonomic Steel Table", 114169.089448511429706m, 17070.4816128646962076m },
                    { 496L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("503924f1-dd4b-49ab-9022-05dd66e1f9d2"), "Ergonomic Wooden Sausages", 78057.3172920022901018m, 718078.571782822118324m },
                    { 497L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("3daa590d-c850-9f3e-901e-b58932f4d417"), "Rustic Cotton Chips", 145772.601857326197774m, 879079.878058539560376m },
                    { 498L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1dd70203-b14a-56c5-764c-6b57fd7a1b79"), "Intelligent Steel Salad", 221279.622686520510698m, 174210.260441898277768m },
                    { 499L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("c8690b52-dda8-b37e-5289-66bc2b780050"), "Handmade Frozen Chair", 160142.000326785781146m, 661930.124107577063054m },
                    { 500L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("54de8444-ee16-a687-e426-4ea18062b2a0"), "Fantastic Metal Pants", 450846.374990381634130m, 378454.678292135597988m },
                    { 501L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("7f702940-e01a-2f73-2255-97e249624c68"), "Incredible Fresh Pizza", 463373.225626613254164m, 860565.766105304523442m },
                    { 502L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("57e8ed36-1eb6-2c24-2560-bdf6ec2ed025"), "Rustic Frozen Shirt", 903135.875797763857744m, 426648.263916686574158m },
                    { 503L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("634fe92a-3c3f-288b-cf1b-dafc25174e98"), "Intelligent Frozen Bike", 544759.569120887719590m, 900900.292004744386136m },
                    { 504L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5c7d1b08-bbd5-3539-c2e6-6ecead4833c9"), "Unbranded Metal Gloves", 332449.402166337871056m, 386271.71039601412204m },
                    { 505L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("15d539e3-20d8-189f-d9a0-eadfb1dc95b0"), "Handcrafted Granite Chair", 574197.582287682633712m, 9471.1937346297498898m },
                    { 506L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("31b24fe6-1a4f-88e0-7c9c-1bdf9c16f9a9"), "Fantastic Frozen Gloves", 207816.600618581498772m, 716194.628718093783568m },
                    { 507L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ca3bc3e2-c10d-d84b-7e39-def412ca6ca9"), "Gorgeous Plastic Chicken", 760740.118777934481570m, 647800.196868413061204m },
                    { 508L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("4b3c3672-8832-1170-6f71-049ee0cc041f"), "Rustic Frozen Sausages", 764965.234859902417136m, 460870.023285753948712m },
                    { 509L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("6c9c188c-1f6c-fe07-a72d-66aa886bc617"), "Ergonomic Metal Car", 666899.955969691459458m, 534411.634067968217252m },
                    { 510L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cd660a5b-bad9-f292-2646-fe16ccac5237"), "Gorgeous Plastic Tuna", 713008.339454921055096m, 293862.84166885121258m },
                    { 511L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("08d48d0d-3f4b-551e-ab28-0ad1fd39ffbb"), "Licensed Cotton Cheese", 472169.287857566607938m, 705878.608558176367566m },
                    { 512L, "The Football Is Good For Training And Recreational Purposes", new Guid("f00ed7ab-67a4-2342-87ee-f487b9da0aab"), "Incredible Wooden Computer", 563250.249221162556172m, 914980.50023136961194m },
                    { 513L, "The Football Is Good For Training And Recreational Purposes", new Guid("3427c57d-b16a-f0db-dba7-69411fb8a351"), "Fantastic Concrete Fish", 648526.520327523237684m, 502648.842673320057968m },
                    { 514L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7710fc71-8b14-3bd7-e5e9-15e7bc4bbe51"), "Small Frozen Bacon", 153031.719261943352012m, 686870.991541770430998m },
                    { 515L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("abf306c8-98eb-f6e7-7568-9a1c1e1d2cf4"), "Gorgeous Metal Mouse", 859442.529103175020658m, 93822.9219558763998088m },
                    { 516L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8ff3e34c-3918-a021-61cd-09aac91c8ec8"), "Licensed Soft Soap", 638073.548075484553734m, 835886.770979053492122m },
                    { 517L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("d8096460-37cc-96eb-7d81-1ae934ea7ac3"), "Tasty Fresh Sausages", 340278.31703792481216m, 661024.533214224472130m },
                    { 518L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("f2a6a2af-7d1d-6fd1-dbb0-943e006ce88e"), "Tasty Concrete Mouse", 943903.751680554020334m, 289312.259380382991882m },
                    { 519L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("93f2e53a-e5b9-fc6d-adb7-07af037884a1"), "Gorgeous Steel Computer", 317364.90925332203518m, 71839.0192544606384270m },
                    { 520L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a28078d5-ef5b-055f-4e73-24c0a7ccede9"), "Ergonomic Fresh Shoes", 637608.779619454324872m, 625764.947424556090092m },
                    { 521L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("81abdafe-79f6-68db-250f-59c313214d4b"), "Sleek Concrete Salad", 732283.028192800480428m, 693200.073175201847758m },
                    { 522L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("68e23dc4-4435-f151-9389-3af9be3b7faa"), "Tasty Steel Shirt", 102162.486637539078158m, 972526.344240685409472m },
                    { 523L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("6e7da889-f5ba-b58b-82f6-e08ae82d8361"), "Unbranded Plastic Shirt", 91607.6630695706334736m, 786913.132982320380532m },
                    { 524L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e6376091-7c95-5deb-c17a-3ec557813c1e"), "Practical Soft Chicken", 694065.354708522319984m, 193456.587022129131846m },
                    { 525L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("b5bf0db7-c0f6-0e92-6808-d4e6e6535822"), "Generic Cotton Keyboard", 722734.558119814820356m, 800474.945902671292470m },
                    { 526L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("69ba8caa-adfc-cc35-6133-41aa3c91aa83"), "Gorgeous Metal Tuna", 798313.259910680923212m, 369472.381730421650674m },
                    { 527L, "The Football Is Good For Training And Recreational Purposes", new Guid("ad884dcd-b08a-400d-2ad3-8396811da248"), "Small Frozen Shirt", 914693.327991679240012m, 955938.295729548784072m },
                    { 528L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("41d48d5d-f9fb-6351-4971-33bcaedfbe77"), "Fantastic Cotton Bike", 164515.719802376335052m, 138484.4562498335654m },
                    { 529L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ee2cbef5-c5fa-4959-bad4-2e9a797bfe0c"), "Handcrafted Wooden Computer", 128688.570130227988234m, 709956.670537338096962m },
                    { 530L, "The Football Is Good For Training And Recreational Purposes", new Guid("acbf2cfb-7d48-9135-7298-a8759f6c9060"), "Incredible Metal Chicken", 466282.674979602910364m, 915433.474274986712806m },
                    { 531L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ce5e040f-778a-11c7-c98d-7df1e7bcb52a"), "Practical Frozen Bike", 502589.961549379541374m, 324924.269398513507296m },
                    { 532L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("ec04f040-ec36-5895-d70a-e1b8be4bf1d3"), "Small Frozen Towels", 537299.704461816877250m, 239960.340264715631288m },
                    { 533L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("7c0a69e4-fd42-b369-1e43-34c77d4c5433"), "Gorgeous Plastic Shirt", 881403.022018241348378m, 696000.492802301391858m },
                    { 534L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d4b2cff0-bfa9-b2ca-1bd3-a889e9be4e99"), "Gorgeous Soft Bacon", 520858.619092022381312m, 550580.167195459288008m },
                    { 535L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5f8ee060-05d3-92f0-e179-01f6a5917830"), "Incredible Soft Hat", 807625.962698479096730m, 478153.047264470859044m },
                    { 536L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("fb536198-3bab-d80a-1de0-ce2efe4a54d1"), "Tasty Frozen Mouse", 828523.288537880828456m, 623199.17381956956318m },
                    { 537L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("41f48677-dd98-dcf3-74bb-d3dea662b90c"), "Practical Metal Table", 896757.951765872433274m, 55516.3823690489999284m },
                    { 538L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("bcf25fcd-9e63-ada3-2264-36252d4562d3"), "Fantastic Cotton Mouse", 442534.024691729480902m, 434753.65279941538708m },
                    { 539L, "The Football Is Good For Training And Recreational Purposes", new Guid("034a3f04-f3ba-91f9-9601-38f410cebfde"), "Licensed Fresh Fish", 836952.82207032804536m, 559036.419350319153212m },
                    { 540L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("435fbde3-4422-41db-9080-78780a4a53b9"), "Intelligent Wooden Sausages", 471396.038876711662650m, 176961.824752606650072m },
                    { 541L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("46188380-f2e0-216a-c28b-419d27b6f73d"), "Handmade Fresh Chair", 810359.098088649383826m, 744600.363422170752248m },
                    { 542L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("fb971aab-54a5-d286-2927-f151192a420f"), "Small Rubber Table", 168604.716473580636624m, 179171.681016630282582m },
                    { 543L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("6d9cc356-4aa1-bb30-c0a5-e4b3c28f276a"), "Tasty Wooden Soap", 213101.064995345607344m, 248038.323907974032772m },
                    { 544L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("6b9623d8-a3b3-341d-25e1-c53cae60cdc5"), "Small Granite Table", 310435.717655274948096m, 102404.316629651126612m },
                    { 545L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("e27128d1-6cda-3ebe-77f8-6b1b73de6617"), "Handmade Frozen Towels", 611832.892170921325694m, 826960.792596754960704m },
                    { 546L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7fe160ca-7c10-dd4b-19d0-05d8a7c554b4"), "Ergonomic Soft Keyboard", 780184.773131138996388m, 372109.621186443189652m },
                    { 547L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("01159c48-a9de-2c61-973c-72cb98f4c534"), "Handcrafted Soft Chair", 511908.285143546079672m, 787424.892035879226374m },
                    { 548L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("71ea8684-a19f-3705-b3e9-188f2e3ac98b"), "Refined Cotton Keyboard", 722944.942327286563874m, 401587.081604082444296m },
                    { 549L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f1f055b1-0b03-d32b-49c9-f13a9ac52815"), "Gorgeous Steel Towels", 23746.7838836511493722m, 184972.288493728125910m },
                    { 550L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f020a644-5864-cb03-c2ee-4f1a2df6bfa1"), "Licensed Fresh Chair", 631791.38705498872342m, 183643.304685152059008m },
                    { 551L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("35e99913-7fb8-08cf-563b-d63ffd33a483"), "Generic Cotton Shoes", 447254.619873725234492m, 279876.760661530171658m },
                    { 552L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("9fc59e3a-fe04-c401-8224-14e2baae3416"), "Tasty Wooden Salad", 361079.504890160902770m, 972493.893450934118778m },
                    { 553L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("6925200b-960e-c89e-268f-8f43da80df75"), "Tasty Soft Towels", 221236.989247459559354m, 90822.0207686314779274m },
                    { 554L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("1db0a4ee-3a3d-eed1-a229-96dc7df81301"), "Handmade Wooden Pants", 266743.417654263719668m, 411382.000918648635408m },
                    { 555L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2f74adeb-89f2-b48d-fcd1-251952b38954"), "Rustic Cotton Sausages", 505208.055054684058370m, 239189.458968476307298m },
                    { 556L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("956f9b9e-b47e-16d4-2b2c-b0d00c612811"), "Generic Fresh Hat", 273911.003193886970022m, 809117.770483658559128m },
                    { 557L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ed276d6b-2847-9723-1d48-e18a5b45ebbe"), "Refined Soft Gloves", 754602.031184301221236m, 348148.049668964071088m },
                    { 558L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("90025ba9-0800-3a9e-f6b3-edaa1fd1affd"), "Awesome Soft Cheese", 312930.142521886237154m, 525143.486128331169192m },
                    { 559L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("24fe3626-a736-2ef5-f1fc-fe3ead3fb828"), "Generic Wooden Salad", 869411.883750371848766m, 128683.784434568398696m },
                    { 560L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2a8b24ee-9682-65db-5128-84fbcdb11153"), "Tasty Frozen Hat", 923187.906927551389884m, 902518.585918617085202m },
                    { 561L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("c2a63841-2383-8b86-6589-c1c4de1993e9"), "Awesome Metal Soap", 498194.822484347252030m, 436908.664221134923578m },
                    { 562L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e3311894-dc55-262b-30c5-98b96a1a0512"), "Fantastic Rubber Towels", 789516.918363931202148m, 907904.086129749120894m },
                    { 563L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("586c57b4-5ef3-6a38-2d4f-0aac38b032f5"), "Generic Metal Soap", 717126.911806641877332m, 648685.210504380249208m },
                    { 564L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("5a10187b-37bd-12c7-4789-443a318783a6"), "Handcrafted Granite Pizza", 520623.619086292332774m, 2156.33487681717500890m },
                    { 565L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("0df54b86-f5c6-2b19-064c-10539f7458a7"), "Incredible Rubber Pants", 852045.118102993610724m, 437578.414800219086402m },
                    { 566L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("333a69f4-b491-c96e-2c5d-1719ac79d424"), "Sleek Cotton Computer", 691638.183452481540770m, 734883.501414100635914m },
                    { 567L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("d77200a8-e4d5-411e-b09e-29acded7f8bf"), "Sleek Cotton Bacon", 76099.5838818604413348m, 740625.566198624098562m },
                    { 568L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d7ee3bd8-babb-a6f3-2578-c250faed6323"), "Unbranded Metal Soap", 381615.464219864099362m, 401228.357286677514006m },
                    { 569L, "The Football Is Good For Training And Recreational Purposes", new Guid("336de13e-5d7f-3715-6137-06423f659047"), "Handcrafted Plastic Salad", 570.156912509145349506m, 123690.629241028758436m },
                    { 570L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("6143fa53-325a-576c-348d-679ebbf03c3a"), "Unbranded Metal Chicken", 872755.604371213232174m, 74110.3271500850619284m },
                    { 571L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("870d4542-6cc6-3664-7c26-b8062b619734"), "Handcrafted Concrete Gloves", 221098.267437522734116m, 753156.628662649046162m },
                    { 572L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("65cfc7f3-c50c-f245-7b14-df98dbd0a9c1"), "Incredible Metal Gloves", 626510.236106315745412m, 981822.965483028738226m },
                    { 573L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("cfccc7ea-0330-d1ea-609e-a6bc8c01c7cb"), "Handmade Steel Keyboard", 209158.895139386087974m, 7438.19186151426814452m },
                    { 574L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("52a64c5f-74d5-e196-142b-a3d351660c99"), "Ergonomic Soft Mouse", 249337.058725507202756m, 859626.689843809802744m },
                    { 575L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("922e6010-3294-3464-4b12-86a3a6419568"), "Refined Wooden Chips", 131140.396735745969872m, 247079.567630623422506m },
                    { 576L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("13f5c766-21d1-dc42-aa8b-ab60ad67ac0f"), "Incredible Cotton Salad", 747573.791453259796334m, 495156.31656083625310m },
                    { 577L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d10f63cd-ea6f-48f8-c474-5a94d78cae01"), "Small Granite Bike", 351000.44828212943514m, 639629.785940423598892m },
                    { 578L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("94e32317-f0b5-8bb7-6fb7-4a31a4784834"), "Incredible Steel Table", 661188.018995446255742m, 84187.4708438680657070m },
                    { 579L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("5ca34dbe-92f2-da97-257c-6156cc55ec34"), "Awesome Frozen Keyboard", 27421.0418883312429506m, 374915.585569142200374m },
                    { 580L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1e29ad35-4b99-4878-2b69-0ca6ddc4ce98"), "Awesome Plastic Salad", 68692.3109010969320130m, 379320.340836938045726m },
                    { 581L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("23f4fb8d-d9c1-91bc-8d7d-134f365d38e6"), "Small Steel Bike", 434702.963361418465832m, 12567.8054139810047158m },
                    { 582L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("fb50012b-a411-98bf-1730-9d9f40958ece"), "Practical Metal Chicken", 164695.654345916528232m, 110656.221937440503346m },
                    { 583L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7b8ebded-cb1c-5c22-ae98-08a304559b36"), "Small Fresh Pizza", 959651.936757471873632m, 997583.183270357122572m },
                    { 584L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("af4a0f5b-b0a7-e026-58a1-35fff5c19aaf"), "Rustic Granite Pizza", 475672.300936911437168m, 700860.734727461100532m },
                    { 585L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("4fe33855-3c79-79db-8f2d-aa691f599911"), "Practical Rubber Tuna", 235846.040969041679866m, 56071.3615553383074286m },
                    { 586L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("a70029c1-06d5-b7cc-92a6-a3d9e51c4bf1"), "Sleek Cotton Shoes", 2351.07716747522472208m, 627195.246333594550808m },
                    { 587L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("13599e57-c7ff-b5e1-dc33-abaef6988f51"), "Generic Granite Shirt", 200341.72288239287072m, 571625.838225780044514m },
                    { 588L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d040068d-a055-91f6-1289-8ad00e3fe634"), "Tasty Soft Tuna", 914349.917495093606828m, 247939.057881694482396m },
                    { 589L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("05ea57fa-4dc1-3fbc-ff42-990336b4057b"), "Refined Wooden Towels", 111778.611892375103908m, 394083.92547924270666m },
                    { 590L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("01b6acec-8be4-9d37-302b-5a458bd5b3a5"), "Small Fresh Pants", 505069.449901026920106m, 465396.507289216835814m },
                    { 591L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("0235307e-16c9-5d23-e5af-0aebab6aff3d"), "Sleek Cotton Chair", 450619.03595516561392m, 48582.2946924238895848m },
                    { 592L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("047bc9c1-bb25-b2df-76ef-2853cce8db76"), "Sleek Plastic Keyboard", 169026.263080496736602m, 372799.283884014035854m },
                    { 593L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f4eddf3c-c4b3-5fbe-85ee-7fcb0b6c8b88"), "Handcrafted Steel Ball", 434567.434143711443364m, 971797.518264485277182m },
                    { 594L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("be0c1b4c-a815-ed39-0d44-c0f75f4cd52e"), "Rustic Plastic Pants", 448066.474145666443186m, 668093.816697226228936m },
                    { 595L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cf69e988-0f20-374a-0ab1-74c7bc2e686e"), "Handcrafted Metal Salad", 341158.428855473656608m, 351960.173362028436434m },
                    { 596L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("b6ad3a70-648e-d38a-da6b-aa842fb74b9d"), "Ergonomic Concrete Towels", 531107.089142804285786m, 308399.885331323739344m },
                    { 597L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("4e18dc4d-588e-6647-1311-87f3b4460151"), "Fantastic Steel Bacon", 28722.6606968866193542m, 891238.119905808232774m },
                    { 598L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("095e689b-0229-f73f-a1e0-df21331abcb9"), "Small Wooden Shoes", 32885.4183737048146538m, 472141.399230805973014m },
                    { 599L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f90d3137-5763-2002-d75f-4f5dd42f4ba6"), "Licensed Rubber Pizza", 178155.586770489839248m, 267582.168019667633852m },
                    { 600L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("1981a19b-3ad5-e44d-1b61-f8ee7a92248d"), "Tasty Concrete Keyboard", 292595.760082013454592m, 27619.8549840482562626m },
                    { 601L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("4e3c5fdb-e41a-47f8-e144-026f753304eb"), "Fantastic Soft Chair", 434858.203760862045982m, 720287.221355900137552m },
                    { 602L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("82902992-a8a3-0e6a-5959-f4089d6bbd73"), "Sleek Soft Pizza", 974036.309534928781112m, 526862.004359331833104m },
                    { 603L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("999e12dc-3c80-0302-ab4e-f22e63f9210e"), "Ergonomic Granite Salad", 526154.461904913572116m, 964739.762784208468814m },
                    { 604L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7028fcb8-054c-72a5-6574-d3915ed2e208"), "Generic Soft Table", 30636.5143047756481464m, 974546.017162586486962m },
                    { 605L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("73e65db1-377b-7414-93d3-d0447ef0c744"), "Fantastic Rubber Towels", 573187.553660757927684m, 240875.873106892284796m },
                    { 606L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("886f2d32-81f1-7490-dc7c-57c97cb27c06"), "Incredible Wooden Pants", 850642.530115073196928m, 796275.502591566712486m },
                    { 607L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("5d909006-684d-42af-8073-f80c8b78d501"), "Fantastic Rubber Shirt", 737932.791632192002546m, 66890.838027718384676m },
                    { 608L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("accf88b6-cf9d-d4f0-f494-772f864e50a7"), "Handmade Granite Shoes", 560891.877326342779318m, 300723.892571726962570m },
                    { 609L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("912e8fd7-8ce6-5a7c-a86c-9f5a5559d197"), "Licensed Soft Bike", 764966.872352514425362m, 910138.51295425353416m },
                    { 610L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("9696e46f-f991-cd29-d08e-edf5909d78c2"), "Incredible Concrete Shirt", 352821.989458120796978m, 327281.099829642217698m },
                    { 611L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("ff699bae-dd3d-36e1-55a2-0275a4ea1308"), "Sleek Rubber Mouse", 408959.63777235861746m, 294477.589956109179066m },
                    { 612L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5e6ed9a7-1895-652e-aae6-f0d8ff06c703"), "Incredible Fresh Sausages", 890735.377277726499912m, 279079.138957648769914m },
                    { 613L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("5e1b0b37-f57d-a6f5-f778-af1f71357979"), "Fantastic Frozen Hat", 387999.809270448460762m, 454017.327681364568328m },
                    { 614L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("6255f272-1d2e-3198-1486-1169636d217b"), "Unbranded Rubber Chair", 651153.929585471212130m, 513318.267057935610954m },
                    { 615L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b2c3a3ea-4f9a-5c0c-c59d-23cd9910f57c"), "Small Frozen Ball", 183070.024377440967556m, 837403.638691739999266m },
                    { 616L, "The Football Is Good For Training And Recreational Purposes", new Guid("7f563ccd-ee3e-1d40-78b4-6fcc8c6165fc"), "Gorgeous Wooden Bike", 933862.281402880741642m, 904112.606149055248232m },
                    { 617L, "The Football Is Good For Training And Recreational Purposes", new Guid("9f1642e3-7cfe-40ae-9411-4a841409505e"), "Gorgeous Metal Bike", 72789.4204649914157530m, 481958.369481018204630m },
                    { 618L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("fd1d0659-f802-4dec-6f49-0aafd84c4dda"), "Generic Fresh Mouse", 989425.449663410967464m, 467782.877214098440552m },
                    { 619L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f6fa97ab-b791-b967-07bf-b67c79f9fb94"), "Refined Plastic Tuna", 747159.458149772060646m, 28110.9092082948435486m },
                    { 620L, "The Football Is Good For Training And Recreational Purposes", new Guid("ac5bb1f6-b9c4-6114-f5a2-e32b4b9cbf28"), "Tasty Frozen Salad", 53565.2109186170054938m, 335779.27268697151028m },
                    { 621L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("245928ac-81cc-82df-3524-cd580c7e7570"), "Generic Rubber Towels", 151669.240230359865106m, 657314.781837058065498m },
                    { 622L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("adb086e4-73c9-729a-0e6d-d05210f49f53"), "Small Metal Hat", 31903.4074397732105686m, 223719.732367949387382m },
                    { 623L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("a77d056e-0f61-b140-c4cd-c1a9ded30e19"), "Generic Wooden Bacon", 517704.579132928915684m, 89939.247142700960890m },
                    { 624L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("7c7fbc99-4c7e-be05-952c-ecbf6557a178"), "Ergonomic Cotton Pizza", 208721.4249632151902m, 755365.035697391143032m },
                    { 625L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("bdb3b31f-dc15-b357-990b-cb18fd0c671c"), "Small Plastic Salad", 137932.562891466489712m, 120745.933647376724546m },
                    { 626L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("a504d9eb-d794-03f3-13b8-129efacb228f"), "Ergonomic Frozen Mouse", 131005.508807240366436m, 150570.723394333931234m },
                    { 627L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("9ae3d75f-6ce2-f1d1-19fc-d73cd15082b8"), "Sleek Plastic Table", 54514.4715150180156418m, 347471.057750367616254m },
                    { 628L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d503e2f9-968c-f72b-ac0f-10ffa39e9231"), "Incredible Concrete Chair", 600332.864774803118132m, 497503.956984313015566m },
                    { 629L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("dc25dce8-afe1-96e5-7f56-5dd45d721ada"), "Awesome Wooden Hat", 966591.255859614912014m, 694751.308250040493128m },
                    { 630L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("bc8b123e-977c-dd84-0e58-bb9e6ecf2826"), "Gorgeous Cotton Tuna", 237217.071086842960132m, 195002.065112367769444m },
                    { 631L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d6738dd7-63d2-d911-eceb-32f71fb91259"), "Generic Cotton Table", 247072.779552768605368m, 247634.368992937478668m },
                    { 632L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("57ac2661-9479-b7f0-6327-00faffd4ecf0"), "Sleek Metal Car", 512852.951578477431136m, 229129.425143385197696m },
                    { 633L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c0c31952-8537-d849-78ee-341f99c3aa79"), "Small Concrete Soap", 590739.834122475794986m, 501936.014119646016636m },
                    { 634L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("777f5b3f-f3c9-e285-3548-a476ae39abcb"), "Handcrafted Granite Gloves", 440212.053854253443756m, 936648.667719951961932m },
                    { 635L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("baf0c065-42f6-0213-2a09-be197bfe8899"), "Licensed Plastic Keyboard", 413827.987228813231114m, 309112.682338673873450m },
                    { 636L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("bd4538ed-8650-46c0-c5cf-04df677a9ff9"), "Awesome Granite Bike", 256324.601732414238714m, 33055.3362614419595066m },
                    { 637L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("18aadc49-542f-a3e3-01a9-9b9842e77969"), "Fantastic Fresh Towels", 194393.588557330313430m, 230754.2435636898578m },
                    { 638L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("86ab8f74-0938-9c79-8514-2873ee994ef2"), "Incredible Concrete Chips", 926091.551136250357886m, 648511.419292114368906m },
                    { 639L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("ba63bd1d-19bb-4e18-1742-0adbbd8fe219"), "Handcrafted Concrete Cheese", 471059.613527160707456m, 545369.914610906298166m },
                    { 640L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("cd5d3a7d-83f3-0b01-5f82-09d083e6fdbc"), "Refined Soft Salad", 477756.51073401750610m, 508568.107891397944704m },
                    { 641L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b2e2e7d1-e3f0-3c3d-1032-e8054d7eb4e4"), "Incredible Concrete Shoes", 203173.926039880226910m, 226460.694553537052336m },
                    { 642L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("172f7480-e545-7d99-6c2a-d85703f98a53"), "Sleek Concrete Chips", 555764.110910423122264m, 780495.558230749554024m },
                    { 643L, "The Football Is Good For Training And Recreational Purposes", new Guid("474ad1ee-1007-7270-e179-6be13bfeb333"), "Fantastic Steel Hat", 228122.696673139165110m, 696057.830128231510648m },
                    { 644L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2568f91e-4b91-3152-c495-11d0598c08ed"), "Fantastic Granite Tuna", 862138.384377965687634m, 189586.971291157072284m },
                    { 645L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("a91957e8-cbdd-7743-df73-88f368b2f96d"), "Tasty Metal Bacon", 963643.13563170416034m, 302357.909801124967692m },
                    { 646L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("450abb0f-6a67-cc9e-9ddb-8c36dce6fdf2"), "Practical Soft Table", 748252.630562668862154m, 509840.475236076165868m },
                    { 647L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("40f786b1-ebbb-4d8d-3944-7685569c90b8"), "Handmade Wooden Chicken", 933835.524575549503332m, 603282.225560953748364m },
                    { 648L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("b85949a5-9d29-fefc-8be5-da884319c6bc"), "Gorgeous Frozen Shoes", 793854.388498445583204m, 651051.049155911482772m },
                    { 649L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("4fc40e5f-3322-d537-6188-bc2fcb7cbd50"), "Refined Cotton Gloves", 496206.534501500170892m, 310616.685127705279364m },
                    { 650L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("0058833a-baaf-93e3-5f37-5ca86abc6544"), "Awesome Frozen Fish", 202257.155633820706118m, 370243.329244524538672m },
                    { 651L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("604f3f00-fedc-55c5-b683-655bbbe884a5"), "Unbranded Concrete Soap", 653580.315394181889146m, 76303.7791546512789704m },
                    { 652L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("8672ed1f-b005-3c9a-0de9-2a8d19bd1e45"), "Sleek Wooden Salad", 975051.306655397480178m, 381947.437705437800318m },
                    { 653L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1aa29939-5367-814a-409b-1c052f80ca86"), "Handcrafted Frozen Gloves", 130986.65334373936886m, 922418.69480790070604m },
                    { 654L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("661bd206-cce5-56f3-e80f-03de070044d8"), "Ergonomic Concrete Hat", 238476.93957840693752m, 410071.108023067670152m },
                    { 655L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ee787e29-dd6e-d2b2-b6d2-ab3882bbd856"), "Awesome Steel Bike", 498314.157884971973438m, 781485.676314337426368m },
                    { 656L, "The Football Is Good For Training And Recreational Purposes", new Guid("a70bf673-cdd7-fca8-0d96-965ae39abc81"), "Practical Fresh Ball", 697644.768704607010130m, 379479.637071805938804m },
                    { 657L, "The Football Is Good For Training And Recreational Purposes", new Guid("eb9c299b-165c-3b6d-9da9-1eba54e708da"), "Handcrafted Metal Salad", 937863.952221630097428m, 311669.689562582197584m },
                    { 658L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("26aacec3-bc8a-ef15-3f8b-def1c4b2e019"), "Gorgeous Plastic Bacon", 779844.922138709340654m, 406139.101032485379376m },
                    { 659L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e236b089-b01b-6b7f-c922-2f36e7f2478d"), "Small Plastic Chicken", 560109.356354070853952m, 341178.507197018893204m },
                    { 660L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("4c0a33e5-6206-093a-a63b-f0282efe41f1"), "Fantastic Frozen Tuna", 525262.150382532186132m, 7647.27132082105321144m },
                    { 661L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f00b8ee2-b6ed-b998-6273-85b771b81e00"), "Licensed Wooden Table", 16630.8610050237703754m, 819527.45688668811424m },
                    { 662L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("a03c4255-8c2c-1b49-88a5-d178104f47db"), "Fantastic Steel Hat", 443275.11866956956084m, 867162.386979709388096m },
                    { 663L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("059dbdf4-5e08-63f1-a8c1-bffdfbc167b7"), "Sleek Fresh Sausages", 535189.652284669671770m, 759416.094203459926628m },
                    { 664L, "The Football Is Good For Training And Recreational Purposes", new Guid("e31b22f6-3a40-c58f-d866-ac456b19b860"), "Incredible Frozen Chicken", 899964.268374971389784m, 587159.678499690361208m },
                    { 665L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("808222f2-81dc-b1a8-8927-357ab6726989"), "Refined Concrete Chair", 498387.088666224119210m, 141227.784074820942092m },
                    { 666L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8c0a51a9-81e9-5071-9fac-73b0e99eda96"), "Unbranded Wooden Hat", 932534.824741004375232m, 939787.697157078531536m },
                    { 667L, "The Football Is Good For Training And Recreational Purposes", new Guid("0d2d8884-e817-1930-ac2a-43ece49803dd"), "Licensed Steel Shoes", 801497.963484092037550m, 99802.9889205404501650m },
                    { 668L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ba879837-34aa-5ba9-c107-5fb433dc2af1"), "Unbranded Cotton Sausages", 987399.297850323698262m, 960098.531975362651466m },
                    { 669L, "The Football Is Good For Training And Recreational Purposes", new Guid("790e9048-1c8f-c200-98ff-cc42838ee876"), "Handcrafted Cotton Shoes", 293238.457675746696330m, 142323.330929086851364m },
                    { 670L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("e245f0e2-3081-613a-6f85-f02fea4c9909"), "Refined Cotton Bacon", 239428.768920389446230m, 939382.299259114949058m },
                    { 671L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c8523012-d648-39ae-84e7-644d3d33fd39"), "Tasty Soft Chair", 586936.93579540066076m, 230769.841980177962430m },
                    { 672L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("a8403415-ce75-73f5-c612-0150f3ce7f8f"), "Fantastic Cotton Hat", 811705.407729700716474m, 306672.76014870301310m },
                    { 673L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e6a3d41c-200e-e315-3465-11e040abc324"), "Tasty Metal Computer", 831497.958455393094728m, 975665.789483352366332m },
                    { 674L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("c6ba0308-fad9-c9e9-1f70-416a3f1ec870"), "Generic Frozen Tuna", 484710.853969299218108m, 591606.734902381767564m },
                    { 675L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("da57fa3f-062f-363c-1f59-4668e2c29025"), "Intelligent Plastic Chair", 131943.967532921161232m, 81230.0900358786112328m },
                    { 676L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("bd7438e6-82c2-48d3-8737-e2e84ca9156b"), "Fantastic Metal Hat", 663512.91495037604628m, 724080.011714884248392m },
                    { 677L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("1dea2ada-a063-6170-b5bc-490b9c9fa2eb"), "Refined Rubber Car", 482643.069201293025276m, 230759.87488345719574m },
                    { 678L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("2e83f880-9e40-8399-53f9-6c6fd94de829"), "Practical Rubber Shoes", 187311.201564633628428m, 701221.130550126013616m },
                    { 679L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5675f9a5-d09e-2d3f-06ee-2b0e62423b52"), "Ergonomic Fresh Chair", 395628.489146055194768m, 691154.900513429352010m },
                    { 680L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("378fb5a7-2de7-8e9f-52a9-10db6b357d34"), "Unbranded Cotton Pizza", 931740.401099754835432m, 691261.220016527920534m },
                    { 681L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ef5ffd37-74c0-3356-0362-ebf28e3c886d"), "Unbranded Plastic Chair", 45695.4735203420810562m, 612837.961268778109696m },
                    { 682L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f0c49668-0ca1-eed9-e5ce-6d5c4117d4b2"), "Fantastic Steel Shirt", 479956.293241318692350m, 796906.37332201572810m },
                    { 683L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("95841637-4fc2-bad4-53f9-72e7373ad987"), "Practical Frozen Chair", 559680.788851026574314m, 284452.955810057569786m },
                    { 684L, "The Football Is Good For Training And Recreational Purposes", new Guid("c5be0bf1-f2c8-4d58-99a2-fe2481d29241"), "Practical Granite Car", 21314.7858476553493754m, 859191.47057017209090m },
                    { 685L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("04bb4262-9e99-116b-884d-cbd45599082c"), "Rustic Frozen Bike", 865470.440227493660328m, 174836.058342734972898m },
                    { 686L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("5fe2f55e-d524-d996-99a2-882632f48231"), "Licensed Frozen Bike", 813537.794955001936308m, 569745.167324908368956m },
                    { 687L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("974c6223-7d35-4f40-b959-c284c6106917"), "Handcrafted Steel Soap", 168584.70948784668812m, 196999.663148856706058m },
                    { 688L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("4dfd0e02-0d45-b686-9bf4-10bdd6332b48"), "Licensed Frozen Computer", 504262.797574610799554m, 732447.815537640131598m },
                    { 689L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2e63019e-d194-c532-39a8-7c0812066fca"), "Practical Frozen Cheese", 345264.585731338480218m, 845677.447237239812966m },
                    { 690L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("9531b01a-5361-2620-6574-6cf9158d6bbf"), "Sleek Fresh Keyboard", 293699.474553848096056m, 110490.285149455743064m },
                    { 691L, "The Football Is Good For Training And Recreational Purposes", new Guid("759c7256-d07e-8523-62f3-0e1ce1d550bc"), "Practical Frozen Hat", 566954.792482954214386m, 909589.09705271753490m },
                    { 692L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("56e0eec3-09b3-2f49-b248-ddb3d4aa4430"), "Unbranded Steel Tuna", 123577.765357028977892m, 523189.881293066654156m },
                    { 693L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("a6069303-79b6-9b65-f038-8d9511f6b163"), "Small Fresh Shoes", 838995.45707648986248m, 292897.708395210620402m },
                    { 694L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("21e538d6-869f-2e75-7920-7188a539e176"), "Small Steel Hat", 181310.427586945586948m, 881823.254604322495282m },
                    { 695L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("6d24f6ef-19c6-bc4f-d664-05b970bc4e72"), "Handcrafted Fresh Towels", 706836.546692068268022m, 522735.392420135217978m },
                    { 696L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("e22ec7b8-cf89-8ef5-1de7-365af453a1d7"), "Generic Steel Ball", 949275.030478218939846m, 652573.531986310732030m },
                    { 697L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("16a7899c-e02d-f23e-b89e-16115994fa0a"), "Awesome Soft Hat", 841563.15767034840394m, 309717.53613589885958m },
                    { 698L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("5782098d-5169-6866-ae6c-70d4e80dddb0"), "Generic Steel Gloves", 282906.48975264887048m, 715555.540643429489254m },
                    { 699L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("2b3c03dc-9367-1814-b5d2-ce5307eedc6a"), "Generic Frozen Bike", 342348.198663868280730m, 158729.819654503774444m },
                    { 700L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("5455d20a-375a-b92f-a005-34f5ef57d42d"), "Refined Wooden Bike", 890380.099600148276182m, 393968.390490818145650m },
                    { 701L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("79344d19-1971-1f45-b81d-3ae418fada0e"), "Practical Fresh Chips", 355801.156490092816342m, 471416.480340946652414m },
                    { 702L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("2d862775-065b-b97b-39a6-e015ab286156"), "Generic Rubber Mouse", 146172.194211855890342m, 222280.939347020184424m },
                    { 703L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("53d659bb-1a9c-4c20-f4eb-7f63db7d7399"), "Unbranded Plastic Chicken", 167340.144843275955530m, 286799.185485007834948m },
                    { 704L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1e4635a4-0bf1-eac6-bc2a-4ed8a775e350"), "Awesome Granite Table", 73428.586453660381746m, 916537.015865517117570m },
                    { 705L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("867c8922-6a6e-b437-427b-86326b05b95c"), "Ergonomic Cotton Towels", 494907.463885493599198m, 21439.194351827543396m },
                    { 706L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("a0c05d8d-f735-7db6-2784-02a10f1a3526"), "Fantastic Concrete Sausages", 912719.492148868820992m, 993827.558846312993188m },
                    { 707L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("ceb50ad9-02c4-d8f7-5b27-7df4678df79b"), "Generic Soft Gloves", 197512.745993441964552m, 336968.45244519723710m },
                    { 708L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("39c9f41a-2891-92eb-902f-02ca7f6a8136"), "Incredible Granite Mouse", 979207.498452554261064m, 788536.489351706148322m },
                    { 709L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("aac4f699-22be-f3cf-7a4d-ddf57b59ec2f"), "Gorgeous Plastic Chips", 60343.9127164336949990m, 967520.714287474338454m },
                    { 710L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("9fff55aa-3b3d-1289-470e-f8ededf18ef7"), "Unbranded Plastic Salad", 936861.892097907353122m, 123301.458899352998472m },
                    { 711L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("948eb1ff-b198-8e87-44c4-b9a79cb6fccb"), "Licensed Granite Shirt", 321412.882124804100292m, 715969.593229831660236m },
                    { 712L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("51aafaf4-0718-89be-f449-1718eb3d9bae"), "Gorgeous Steel Mouse", 471222.526191533727058m, 250630.548488203503394m },
                    { 713L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("0af948be-35e8-370b-a37a-fddb644e9b7a"), "Awesome Fresh Chicken", 995208.165971289220796m, 101668.466045357238608m },
                    { 714L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("bd549a50-6b68-a489-8536-a739b1aa9591"), "Licensed Wooden Tuna", 428491.240872026291556m, 696651.422229289934158m },
                    { 715L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("4b0bbbb0-27f7-75de-0823-d0d5ba7913a3"), "Handcrafted Soft Bike", 550429.367013348255432m, 425234.741415675230282m },
                    { 716L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("f9da980f-9719-759a-921a-fe2c3b8623cb"), "Fantastic Soft Computer", 30034.0946100197473418m, 567395.913217566980674m },
                    { 717L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("3baf6b3b-40d5-88c0-6aee-685e4fa795a5"), "Tasty Cotton Sausages", 879987.030347911353016m, 141058.190830592108924m },
                    { 718L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("041b3231-439e-9cb2-0952-78eb8dbd97fc"), "Generic Cotton Chicken", 265564.894263328215642m, 748061.127171062411382m },
                    { 719L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("72e919a4-c768-a085-c035-6ba886d6adc6"), "Ergonomic Fresh Cheese", 230985.763479912099274m, 630002.122051779886912m },
                    { 720L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1b9d8bcc-ef74-db04-97ba-4b684e0c3ee2"), "Sleek Granite Hat", 95352.5735081858765714m, 302595.144593815433370m },
                    { 721L, "The Football Is Good For Training And Recreational Purposes", new Guid("6299ac37-7509-853c-a7a5-a9195bcf908f"), "Small Concrete Salad", 496616.496361201811638m, 937500.387052868889214m },
                    { 722L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("cbfd1d22-7ab7-e100-c3d8-282efa7bdd95"), "Licensed Plastic Salad", 457625.483586223325958m, 676406.581272509827244m },
                    { 723L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("934f2396-e8e2-f841-35df-353836f21ee1"), "Small Rubber Chicken", 26864.2577514973437594m, 751434.901674267909846m },
                    { 724L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("66bbbcbf-5037-5dd9-e636-33aa4a9945a8"), "Intelligent Metal Towels", 632723.122982804140838m, 785031.224766106340608m },
                    { 725L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("885e86e6-1a30-f1b5-1582-0bc50e6fec55"), "Practical Concrete Car", 358527.757824238241624m, 373830.546015228648368m },
                    { 726L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("8248fce1-b4fa-5ed9-9fdc-27ef8b63c060"), "Generic Metal Chicken", 300858.876215689134710m, 399568.781817217091242m },
                    { 727L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("f6f2a6a3-544b-0760-7488-06e1904ed16d"), "Practical Soft Shoes", 401889.927943330554412m, 564701.054717897759468m },
                    { 728L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("a3790664-d7e1-81ca-1c05-98afbd18caf8"), "Fantastic Concrete Pants", 445019.469599821722918m, 234619.347970741583248m },
                    { 729L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("f26f3a26-43be-7534-28d4-39c47ac2dcbd"), "Unbranded Plastic Shirt", 246459.67379599657134m, 406255.580248591481246m },
                    { 730L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("b3a45949-cbf3-eddc-1541-d00572a372a9"), "Unbranded Granite Hat", 634656.08575292986872m, 551354.793514763550888m },
                    { 731L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("e1795fe2-6ea0-4344-3eda-da0690d25ae3"), "Sleek Steel Sausages", 749500.854997345999892m, 121921.94361147509230m },
                    { 732L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("dde7089e-7c0c-1d75-faf5-577fd4e33299"), "Sleek Frozen Salad", 198077.44652559464144m, 497867.712099287330594m },
                    { 733L, "The Football Is Good For Training And Recreational Purposes", new Guid("6f1d9d87-4b6d-fd70-43bc-855f1c261dbc"), "Fantastic Steel Soap", 346987.866704473640810m, 680700.59659970399676m },
                    { 734L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b8fd5468-eb51-a764-913d-dd64cbb29e5f"), "Handcrafted Metal Pants", 947805.438751645271372m, 65016.7864707007949324m },
                    { 735L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("59eeb9dd-38ff-8a9e-d89b-0e7a1bff1600"), "Intelligent Fresh Sausages", 674410.801373031609336m, 225827.354212841267094m },
                    { 736L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b1be9043-bb8a-4017-6f95-334308338e06"), "Awesome Granite Cheese", 848883.978490075481144m, 579571.62195269780748m },
                    { 737L, "The Football Is Good For Training And Recreational Purposes", new Guid("c8284c9b-9dc8-6d00-71df-a8f1ff2c9ef5"), "Handcrafted Wooden Pants", 514777.997577826732238m, 329907.148435389501988m },
                    { 738L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("12c8c7c4-ebc3-7825-a3e7-371bf6f9ef66"), "Tasty Cotton Gloves", 622528.717410330063490m, 657615.726021669492496m },
                    { 739L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("52f5a2c4-7fe0-103d-021b-0cd3992f6010"), "Awesome Fresh Chicken", 831165.17584483364698m, 373740.287593208853442m },
                    { 740L, "The Football Is Good For Training And Recreational Purposes", new Guid("57035b67-e847-460f-af52-5edfc74ccba9"), "Small Steel Tuna", 697914.81400103033710m, 230964.313826224492448m },
                    { 741L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("8434a891-e566-e89e-0bc2-6c2e095b8336"), "Handcrafted Frozen Chips", 529436.174765988723088m, 480710.187344035471334m },
                    { 742L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("8df37425-a10f-2f12-a6e4-9b33e2a2104d"), "Rustic Soft Keyboard", 639995.652460694094882m, 576794.714961196898132m },
                    { 743L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("25423980-c92a-b3e0-2466-c187c8c75f37"), "Rustic Concrete Cheese", 896619.323594257331018m, 330711.692397698359188m },
                    { 744L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("55f885ce-9347-e6bb-a54c-134c87c6c8a7"), "Unbranded Rubber Shoes", 423124.509852208798158m, 486818.818864138996552m },
                    { 745L, "The Football Is Good For Training And Recreational Purposes", new Guid("21fc22b7-1243-c165-5f4b-049b68c73649"), "Licensed Cotton Table", 299662.693908959532908m, 782641.841782820864730m },
                    { 746L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("231a28af-dec0-8d1a-c8aa-1e4e9aa70fff"), "Handcrafted Metal Shirt", 161298.278179592450412m, 758194.402458996302332m },
                    { 747L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("01965fc2-76e7-0d67-f588-332fc5b44251"), "Gorgeous Frozen Keyboard", 791162.60363319808086m, 901929.74315062597656m },
                    { 748L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("19db0b8e-abf3-586c-5427-8ee0f72b3f58"), "Practical Cotton Car", 918169.84182586366556m, 100338.637254389139870m },
                    { 749L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("55a7165f-a67f-7f40-7a2b-50215a4aa426"), "Gorgeous Plastic Pants", 82918.2317636992030112m, 392540.030379864081010m },
                    { 750L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("8ec3ecea-f5fe-a0c0-bdd5-0df492951ffb"), "Tasty Cotton Towels", 65041.0876873583644122m, 414351.656432751728556m },
                    { 751L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("99b074c7-d6db-71a2-16b5-c9961011eb12"), "Incredible Concrete Shirt", 833614.598014730509478m, 803385.111024946407236m },
                    { 752L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5cad62ab-e7f5-f607-1ba1-012f7bf82393"), "Handcrafted Fresh Chair", 860483.535537953987066m, 445242.512380841268706m },
                    { 753L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("e5ac2e46-9b79-d2a1-6f15-13f6e45d2e70"), "Generic Plastic Pizza", 877180.649512743248898m, 518654.230648781085366m },
                    { 754L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("fb0d2f3f-180f-ea95-b066-cad97185249b"), "Incredible Cotton Chips", 980170.241057521200152m, 550599.527908984783514m },
                    { 755L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("f2433db7-8621-942e-c0ef-b2336733ae1a"), "Handcrafted Plastic Chicken", 873000.096006321983988m, 367068.795918410889058m },
                    { 756L, "The Football Is Good For Training And Recreational Purposes", new Guid("43e74acb-ba8e-b814-cfce-733e42b4d8fd"), "Gorgeous Frozen Car", 537575.957325893044084m, 547266.262338155258262m },
                    { 757L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("38f9be75-d11e-79f4-b618-6d035d606f9a"), "Handmade Wooden Keyboard", 256545.255536229748466m, 690670.815266221782770m },
                    { 758L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("3d01e537-2615-53e2-f6e4-6382e469f839"), "Tasty Granite Shoes", 156026.055368539161452m, 508347.072339266933110m },
                    { 759L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("0428c3a9-2ac9-1fc5-c605-6fad9b2a0e1b"), "Handmade Metal Tuna", 417965.472652318834128m, 787617.450727553072790m },
                    { 760L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("3f1d2c07-955f-3071-920b-6e8c773f4a4a"), "Licensed Plastic Car", 219320.794756239206588m, 972804.767157800461548m },
                    { 761L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("d13a659b-20d1-9262-58f3-f38881259562"), "Generic Fresh Pants", 511892.825473680481242m, 250345.552051031517726m },
                    { 762L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("ef5fecc2-bb35-c76c-6025-23d40149be44"), "Licensed Metal Soap", 173274.881046235810618m, 482333.09420623225530m },
                    { 763L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5e9daedb-181c-7bb4-c8f2-9d0eeac05eb7"), "Licensed Rubber Shoes", 384962.928775841597522m, 840360.251707869140532m },
                    { 764L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("1051d7c9-f13a-7381-1cf2-b898120d0cf5"), "Practical Concrete Computer", 409436.988364803523164m, 284661.796255051844434m },
                    { 765L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("935582c2-b5bc-03e7-1bc3-5fa36a166dc1"), "Awesome Frozen Sausages", 151752.970795167400568m, 693076.325296392100370m },
                    { 766L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("1832d69e-b984-c91d-88e9-2e5253435c56"), "Ergonomic Granite Towels", 695172.594105128097806m, 961733.724185197691014m },
                    { 767L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("1f8b6a6a-960e-f268-2008-3f7b08fdd178"), "Unbranded Cotton Shoes", 886730.206327491421098m, 450887.210520751410048m },
                    { 768L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("fa7320cb-70b5-0be9-2128-729df28a14ed"), "Licensed Granite Shirt", 986593.011335754952552m, 808589.001952187737148m },
                    { 769L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cdeaaf74-0603-5318-2992-8ba0ea2d3cc6"), "Small Frozen Computer", 209034.471329018206406m, 263978.410590790906664m },
                    { 770L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("09f2bdc6-8512-c193-a82b-b897770b9f00"), "Tasty Cotton Sausages", 59872.0884249401652870m, 559810.294403892950558m },
                    { 771L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("878735fa-0c05-6d42-e887-6dcf332bab0e"), "Gorgeous Soft Chips", 199571.720642827429866m, 737966.461522647086956m },
                    { 772L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("61bb09e7-ec21-b641-cd1b-510777d4c211"), "Incredible Granite Towels", 208736.403235394585928m, 931475.355204539686048m },
                    { 773L, "The Football Is Good For Training And Recreational Purposes", new Guid("a868f649-ba62-ed2b-0240-c9a46d171817"), "Tasty Concrete Cheese", 582262.973796845353756m, 940155.425383962606852m },
                    { 774L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("939ae298-6303-f6b7-ee86-a5a7a7115e6d"), "Handmade Steel Bacon", 496482.706341033387136m, 762806.069948505876606m },
                    { 775L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("e62434ee-deea-9571-4293-967537867a45"), "Tasty Soft Pants", 819658.351718270927494m, 511445.34139741142372m },
                    { 776L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("32df747a-6ef6-1a3f-80b9-46ea06d0628e"), "Intelligent Wooden Bacon", 850334.170808899042716m, 576437.071723035805030m },
                    { 777L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("fe6d3cae-70b0-8898-f1e2-15fbe8f49a2d"), "Unbranded Wooden Fish", 970021.715443067023244m, 889554.149936259907764m },
                    { 778L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1c6609a1-1e83-0a84-4056-d2b7f90d35b6"), "Fantastic Granite Gloves", 839455.788761827650474m, 21697.2634187720772286m },
                    { 779L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("6b72e692-d3a7-a74a-ad98-ff7e19377d33"), "Intelligent Rubber Ball", 668504.823876554226248m, 198857.307583564406050m },
                    { 780L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a15ee628-1ae1-1a87-4386-020d1c254ba2"), "Rustic Metal Shoes", 532081.924947096777850m, 816580.003650219377014m },
                    { 781L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("beeb2955-810b-a6c9-b5bc-56cacce7d673"), "Practical Granite Keyboard", 750235.07278857348056m, 887648.405434523534230m },
                    { 782L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("43ef11a3-de8c-3265-3a7b-29be82562894"), "Intelligent Fresh Chair", 159509.721204784554270m, 347909.317511614340718m },
                    { 783L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("11f520b5-bbc4-9601-6733-9c23abe1d282"), "Unbranded Concrete Hat", 242833.03926728013534m, 663843.574298588027216m },
                    { 784L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5da70b6d-21ea-4533-a0fa-c9896bdbe5a4"), "Handcrafted Rubber Mouse", 325533.227613826640832m, 604496.009404337206452m },
                    { 785L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("32dabf15-3a72-5cde-d9ae-696e96412c1a"), "Fantastic Cotton Chips", 236424.02060650309302m, 288241.13146092411532m },
                    { 786L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("90721ad3-e075-783a-1532-d6024643406d"), "Unbranded Frozen Bike", 720529.048370146141750m, 667211.759532681086262m },
                    { 787L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4a8e9155-ca6a-aad3-b208-53157d769f0b"), "Rustic Plastic Computer", 87281.2876524007733496m, 829550.146541896712984m },
                    { 788L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e51d36ac-aff3-db6a-cce9-0430dab300c2"), "Awesome Fresh Bacon", 840061.758290795168656m, 875010.59196072603318m },
                    { 789L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("b9070cc0-c212-ed6b-2fc1-52db5e357d27"), "Rustic Steel Shoes", 616541.395424704984076m, 662631.531164042144490m },
                    { 790L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("dca92cce-0b34-d1fd-cbf2-e29aab14de90"), "Ergonomic Metal Computer", 307096.240907133802312m, 575325.814151497393146m },
                    { 791L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("1234ac09-cd63-0e84-f086-7b086956e73f"), "Generic Rubber Cheese", 124080.700585018510168m, 743091.070932706768358m },
                    { 792L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("8e583caf-4937-04a8-6bf0-d699031cd89b"), "Incredible Rubber Ball", 50447.7287932769261274m, 680282.368966322936436m },
                    { 793L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("209cdf12-53f9-0497-ae74-d0d1ce7d0482"), "Awesome Metal Mouse", 61037.0587658992234782m, 973026.17593741601668m },
                    { 794L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("5bdb8260-233e-0da8-1da2-23acd7833c63"), "Sleek Rubber Bacon", 196113.016122839304688m, 735026.087452426988916m },
                    { 795L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("5f9a993e-fa0d-4e0d-0d42-b4012d8c70e6"), "Sleek Wooden Shoes", 626564.887683446372544m, 268370.870233375051622m },
                    { 796L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("7205779e-7126-dabc-ea01-df051c209164"), "Handmade Granite Pants", 68334.1202210230249264m, 26686.3127143943297470m },
                    { 797L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("e9d426b2-aedd-f05b-2110-a787cc0a523c"), "Ergonomic Frozen Keyboard", 162065.510547094646472m, 386600.169201348197534m },
                    { 798L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("e52aaf92-8d14-2676-3d5d-c27ea3b41e23"), "Awesome Concrete Pizza", 487604.609716924147812m, 411963.806263716618046m },
                    { 799L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("1d2d9eb3-c0ca-1b95-498d-43913ed90e49"), "Incredible Fresh Ball", 161638.790647758152028m, 117241.194113564811156m },
                    { 800L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("0a4946ec-51a1-b2d2-0f6b-be31018fc17f"), "Handcrafted Steel Shirt", 171802.251419078955462m, 324149.900186052029702m },
                    { 801L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("cb74b7de-c8b5-ed4b-2416-c9ff630a3706"), "Tasty Metal Soap", 846852.222988930610472m, 327342.313500406631314m },
                    { 802L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("29fc18e5-5e4c-2ed2-7430-93d77673510b"), "Generic Granite Table", 138124.837552360398824m, 935171.723558428192768m },
                    { 803L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("f6100e63-cb4a-72c3-d694-f5ef1de4f898"), "Practical Soft Sausages", 157462.742385173381424m, 506074.769065943568988m },
                    { 804L, "The Football Is Good For Training And Recreational Purposes", new Guid("06b41021-4034-abb6-4689-980784e43dd8"), "Unbranded Cotton Soap", 882040.765224417385048m, 546768.978572024779662m },
                    { 805L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("ce744e7b-c296-1261-4fbc-99fa02168361"), "Handmade Concrete Ball", 847142.319176337075272m, 983882.109870740726208m },
                    { 806L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("89c57d15-bb8e-be4a-6a96-32bb8c40cc8b"), "Practical Wooden Shoes", 99209.4093761060133568m, 454732.769488136093012m },
                    { 807L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("ca48658b-9de0-2c2e-154f-70d01b58328f"), "Intelligent Wooden Table", 991121.918754923998548m, 643937.082290045670428m },
                    { 808L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("161e2b5a-d2ea-d86c-0401-b01de30e1e20"), "Ergonomic Plastic Ball", 565900.673907202582372m, 606143.268683283059510m },
                    { 809L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c3bc0478-e322-2dcf-620b-800e3195958b"), "Refined Cotton Ball", 660558.921680103402822m, 403448.727062799080266m },
                    { 810L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("92b23d1f-8d7f-9b9f-b8df-ad5ddd43092b"), "Tasty Plastic Sausages", 777740.205260972515012m, 737507.863129341707964m },
                    { 811L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("44ec7550-1a7d-9952-1b96-519531e6c634"), "Handmade Cotton Bacon", 182972.858836819437462m, 983490.963980306071664m },
                    { 812L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("278a77a9-d1a8-37a0-8859-1c54f5647c63"), "Licensed Steel Hat", 134985.311585075891522m, 747055.691516767741722m },
                    { 813L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("c4cd9f9e-ab69-0398-c534-9c2f10fc5f82"), "Tasty Concrete Keyboard", 731246.810041733927442m, 8280.97800677373647426m },
                    { 814L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("37dfb5f0-faa8-4b1a-7384-174c632e2644"), "Intelligent Cotton Hat", 336863.704681082184322m, 49767.337310741312770m },
                    { 815L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("a6fb0d76-7991-8a20-a835-3ecd120c4d04"), "Incredible Rubber Keyboard", 534198.731163591877618m, 211090.340665029310890m },
                    { 816L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ef242e6d-efa5-452e-c1f2-6e007b3dd3d3"), "Fantastic Wooden Keyboard", 249430.478075344129404m, 754978.473191721700624m },
                    { 817L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7e787aa2-2784-b333-ed62-c311495b87dc"), "Ergonomic Cotton Pizza", 612793.877562889697808m, 689361.264168779215870m },
                    { 818L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a6c4cc56-a35b-5bc0-e86f-95eac776aa98"), "Small Wooden Chips", 691550.855941752911538m, 969761.681668279612956m },
                    { 819L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("d90e9a81-bd93-5b40-e14e-20a97e3c3a8c"), "Refined Metal Soap", 364342.139998901634722m, 645204.692777872624322m },
                    { 820L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("068d3e83-64e1-7186-504c-6ec4358be0ee"), "Incredible Soft Shoes", 394387.55922048400964m, 947679.980134540007418m },
                    { 821L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("bc383de2-a3e3-d166-060d-e226b775dfbc"), "Unbranded Steel Chair", 912241.931181116666744m, 663645.033089861238836m },
                    { 822L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("213232ac-7446-91bb-6f4e-11423e748c14"), "Gorgeous Granite Chicken", 811710.782500282153812m, 855659.522069275220516m },
                    { 823L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("42915a8d-771a-8d3a-5ef4-c828d040f313"), "Ergonomic Steel Soap", 145845.822819965979610m, 981223.249295525512102m },
                    { 824L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("c0e63c09-f814-7d82-6a6b-76803bb231cb"), "Sleek Rubber Gloves", 712451.151384330425034m, 399840.631450016738242m },
                    { 825L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("9f792d8d-fee3-44ed-b197-fb7114df0633"), "Sleek Granite Salad", 716406.527489750392658m, 569997.261537965934462m },
                    { 826L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("4797cb62-18f8-51c1-4854-b1e2390ab021"), "Practical Plastic Fish", 548983.616142039781064m, 318377.374136283219390m },
                    { 827L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("85d22242-5b42-9f50-f9b8-de1f698d211f"), "Generic Soft Pizza", 768240.733868403298112m, 654470.0919505982172m },
                    { 828L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("569561a0-66a1-9ec5-548b-fbf40923447a"), "Refined Cotton Pants", 387201.097312339571834m, 651997.524252342504002m },
                    { 829L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e9c5b84c-2b21-1778-1004-810d5cf63510"), "Incredible Wooden Keyboard", 935724.361285097528874m, 587793.836265155293642m },
                    { 830L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("dced2cd0-9d55-315c-d67f-956b0111a273"), "Licensed Fresh Hat", 970572.225183996339342m, 136291.775660427514952m },
                    { 831L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("e5fa7c5b-d9ec-84bf-e245-2de533a5aed6"), "Tasty Metal Pants", 776800.90486233306950m, 470255.051358829262374m },
                    { 832L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("fb2ff4ce-e68a-cf6f-da56-46d98eff2f1a"), "Ergonomic Concrete Pizza", 269221.348532520051412m, 744858.36914772226912m },
                    { 833L, "The Football Is Good For Training And Recreational Purposes", new Guid("8ef106ca-2b8d-ec86-5340-434a6712cddd"), "Awesome Plastic Chicken", 302740.412253778532372m, 109230.358646418788854m },
                    { 834L, "The Football Is Good For Training And Recreational Purposes", new Guid("0c08bc9e-edf0-e561-0a13-cf4220768f06"), "Rustic Rubber Chicken", 893476.571122047846472m, 642026.423609688673792m },
                    { 835L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("ed018c35-597f-b497-c348-c31574f846d0"), "Awesome Frozen Shoes", 253980.157031635018070m, 901549.597969879858636m },
                    { 836L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("61ac2547-ebe9-3747-863f-23b2eb012f2e"), "Gorgeous Wooden Towels", 521067.182391923947254m, 613829.41029651408842m },
                    { 837L, "The Football Is Good For Training And Recreational Purposes", new Guid("4ccb32c0-6682-502d-af70-85d62f5a09b0"), "Refined Wooden Shirt", 475715.722213055711194m, 875264.776829587278716m },
                    { 838L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8d765707-df93-c6ea-0abc-403d890a2696"), "Fantastic Concrete Towels", 653569.023321645079388m, 670785.422600463656016m },
                    { 839L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("932c3068-61cb-ffd7-816b-a9c27512f15c"), "Tasty Cotton Chips", 571656.503013235346944m, 157222.495766957578844m },
                    { 840L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("4ea3a97b-98b0-4a64-afa0-f4c71c64c296"), "Handmade Soft Keyboard", 87214.6684856876732530m, 787122.439535321437302m },
                    { 841L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("575f75e9-c072-b6ba-46e8-de6c332564cf"), "Handcrafted Wooden Bacon", 546500.997998211999212m, 546099.266888559825444m },
                    { 842L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("94479158-69c6-89a5-86ca-28fa430c167f"), "Awesome Metal Pants", 750117.203935973657236m, 945775.80220342248638m },
                    { 843L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("0fce60e5-f1da-b0a9-72d7-d64bd444fe27"), "Handmade Fresh Car", 432313.788824666096054m, 740459.138727139707242m },
                    { 844L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("08c664d0-17d8-220a-0ddd-7e36b1f0b91e"), "Sleek Rubber Computer", 805330.058832777011768m, 614371.732997314517524m },
                    { 845L, "The Football Is Good For Training And Recreational Purposes", new Guid("3198ff96-8826-33bf-e531-20086be0cb4b"), "Sleek Cotton Gloves", 456972.565821234467612m, 20328.116165468360436m },
                    { 846L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("591c35c2-136d-66fa-1c0e-960de277d5d6"), "Fantastic Metal Soap", 873094.528966587685724m, 170961.141994513169038m },
                    { 847L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("b084c256-7061-e899-0286-9e4bdde23d79"), "Incredible Wooden Chair", 576429.876541143197596m, 125865.863438900661738m },
                    { 848L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("443a4a87-7f8a-8450-c4ac-7b22d6e2c52b"), "Incredible Cotton Table", 603497.349263038483698m, 694450.60696924825752m },
                    { 849L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4a19d0a5-268e-41c9-78ee-e85db7c35d1f"), "Refined Steel Chips", 261797.818153114504404m, 90104.8598902385033626m },
                    { 850L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("189a100c-a337-4f5c-e03b-84886cb4dff8"), "Refined Plastic Salad", 506604.84809503739048m, 593289.279145334551468m },
                    { 851L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("07c2a84a-a927-b8e3-03b6-a30400576561"), "Licensed Concrete Hat", 134999.982973743055502m, 709833.474008119648186m },
                    { 852L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("1992925a-ea79-6b3a-066a-b7ee69116ac0"), "Gorgeous Concrete Bacon", 427281.709013810846124m, 555494.120321761379552m },
                    { 853L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("e027fa3e-0dc7-ef7b-2432-6a67e095f0bf"), "Handmade Rubber Car", 975747.4038253893558m, 770391.419175002082156m },
                    { 854L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("02ae4b9f-6d57-3f7d-f40b-a91d3160acd6"), "Rustic Metal Chair", 505064.371064905612664m, 528081.640136936399342m },
                    { 855L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("14ee1a36-a131-e2d6-f5ea-a5a3e84bef21"), "Gorgeous Rubber Salad", 633982.799039908987914m, 847189.10428655266770m },
                    { 856L, "The Football Is Good For Training And Recreational Purposes", new Guid("6b655d43-aec5-9b4e-87da-3f240f5c0bca"), "Intelligent Fresh Shoes", 702932.879332943600972m, 240180.541261427757058m },
                    { 857L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d1fe067d-959a-7601-6ba7-d0c977743e69"), "Handcrafted Concrete Gloves", 155151.347298718799932m, 138027.301760437372814m },
                    { 858L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("87cf92c1-7d5b-a51f-0c3d-e3657c6a12df"), "Rustic Concrete Salad", 410714.259207030729616m, 816816.981022951683638m },
                    { 859L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("3b69e5c1-bd57-e546-a9b9-788e11b5195c"), "Awesome Concrete Mouse", 148172.720973691364548m, 463719.55605467301272m },
                    { 860L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("09cb69d3-fab5-5cf8-a8f3-712d33527e68"), "Practical Wooden Towels", 183121.711590686334316m, 17267.4940253609831638m },
                    { 861L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("592fcffb-de59-8d55-d4c5-23a65f6c7824"), "Unbranded Metal Hat", 307782.01560150767046m, 659634.003782951896804m },
                    { 862L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("644fbefa-1fe9-9467-02e7-b6e58b7c8599"), "Fantastic Metal Sausages", 511213.771052404040018m, 557473.520573586958284m },
                    { 863L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("aed754f0-3bc4-8ed2-49df-eb7132bbda13"), "Intelligent Cotton Chicken", 352760.981563048831154m, 829452.2317089187706m },
                    { 864L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("8abbb668-7fc1-a02d-15e3-44eb6705bf45"), "Generic Frozen Sausages", 678516.410561742809444m, 32475.337564047974294m },
                    { 865L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("fbd5710f-fdea-4cff-fb45-caa8cfe67131"), "Fantastic Metal Bacon", 204070.043334315053564m, 299337.818604870440590m },
                    { 866L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("04e17a5f-fbd5-a4d9-afcb-6132b3038f45"), "Incredible Plastic Shirt", 834378.309309781864524m, 767084.38949039267952m },
                    { 867L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("54591b7a-0bc9-223e-a4ce-833e460323ab"), "Intelligent Fresh Chips", 733380.55839789968010m, 778042.420634810558472m },
                    { 868L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("79cf48eb-4522-decc-23de-837e16339aaa"), "Rustic Concrete Towels", 708443.98944364733508m, 233862.072917874718088m },
                    { 869L, "The Football Is Good For Training And Recreational Purposes", new Guid("3f2f78fa-2328-148e-fc9b-72fbe1413dc2"), "Handcrafted Plastic Tuna", 795631.782746328977846m, 146620.335183284154918m },
                    { 870L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("46779581-7a59-d328-2719-90dbf406a74a"), "Generic Metal Ball", 923851.373978731633650m, 825760.221918885118736m },
                    { 871L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("1fd0ccfd-5488-ab4b-83fc-7c84284e22e8"), "Practical Cotton Car", 954467.242653722819948m, 351537.223431528989236m },
                    { 872L, "The Football Is Good For Training And Recreational Purposes", new Guid("68c1497c-9d56-ff6a-86c7-afb00e3392c8"), "Intelligent Wooden Chips", 262145.75933044275798m, 321342.409211122209548m },
                    { 873L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d052ce77-68cc-beec-2255-8db2a7c54e76"), "Ergonomic Concrete Table", 746336.742144468362124m, 345977.521268588553970m },
                    { 874L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("4253abeb-cc76-ae76-a66b-c28dc3a551d8"), "Intelligent Frozen Soap", 903229.118472224135852m, 629163.417175259994778m },
                    { 875L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("e5ac0c9d-4138-a56c-3cbb-db65eb0239d9"), "Handcrafted Plastic Shirt", 829956.062443142286826m, 29042.2702273347800172m },
                    { 876L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("de5bb94a-e78e-be7e-cfb7-ae08f462cd35"), "Awesome Granite Shirt", 361228.133861128366318m, 484514.882492865954862m },
                    { 877L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("17f7104e-42af-8515-eee2-c0f5257a4a54"), "Handmade Steel Hat", 443332.959761690145234m, 785069.86323819324188m },
                    { 878L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cadcf252-c251-e256-e370-47bf5ebc0949"), "Sleek Wooden Sausages", 249777.528134972621944m, 690217.60137684637438m },
                    { 879L, "The Football Is Good For Training And Recreational Purposes", new Guid("eaab26b0-4346-9c89-52d9-0599fd07c236"), "Refined Steel Keyboard", 980441.466561488107314m, 229473.277443912221230m },
                    { 880L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("2cd0703a-5c96-ca60-461d-bbda6cae4f1f"), "Handcrafted Plastic Shirt", 200496.384854521307814m, 52507.9614320532076278m },
                    { 881L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("c8b5e62f-9165-c2bf-9cfe-e37298882be6"), "Refined Rubber Computer", 649805.10935766206304m, 928313.1770423326592m },
                    { 882L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("0e4a5dd6-8a33-e0a8-8ad7-0117c7dfe2c0"), "Fantastic Metal Shirt", 728686.861138318974088m, 688334.21989431687298m },
                    { 883L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("8732b382-fd92-1c52-00d6-5e6e71cf179d"), "Generic Rubber Car", 938419.037128179063986m, 197982.420043949984836m },
                    { 884L, "The Football Is Good For Training And Recreational Purposes", new Guid("eb4ad97f-fd4e-d54e-935f-7dc53804d061"), "Intelligent Steel Bacon", 118592.839309322013050m, 129445.168260572701146m },
                    { 885L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("68c85a77-b895-d3c5-7b6a-202b296f5c3c"), "Ergonomic Plastic Tuna", 818059.024252211256936m, 153583.636375994916236m },
                    { 886L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("9371f399-13a4-623d-1873-58be0ae29b40"), "Handmade Rubber Keyboard", 536102.367680766228708m, 176658.942531836303144m },
                    { 887L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0128b504-29a5-bfd9-dd98-924ca01a4276"), "Generic Frozen Salad", 307070.915697833322214m, 54924.2777396576271344m },
                    { 888L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("67c70758-c397-e77a-eb8d-4d557f73d420"), "Incredible Frozen Salad", 525458.805634380895812m, 770371.388851426809428m },
                    { 889L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("5ae9b91b-6d82-a93f-91d9-a31dbf41755e"), "Handmade Frozen Hat", 331674.65972514385242m, 990946.00507689605826m },
                    { 890L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7f655a0f-54b5-a31c-c16c-25f253696a47"), "Awesome Soft Computer", 640138.856950287542876m, 544959.859069244021716m },
                    { 891L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f11b40e6-cc0a-13ba-162a-1735469acb9f"), "Refined Rubber Pants", 88801.2139914383155570m, 7418.2879696905914076m },
                    { 892L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7686da3a-b28c-5282-7c2c-edb80cbac8ec"), "Sleek Granite Bacon", 620004.239730044521992m, 989355.739286170000788m },
                    { 893L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("610950d4-8333-bc8f-b7f1-cbdfe001aac2"), "Rustic Wooden Salad", 477077.390526497637626m, 445021.653290282333262m },
                    { 894L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("dbc22eae-21bd-f2e9-8a16-a7c191c64dfd"), "Refined Steel Shirt", 830495.516974730065828m, 625079.808004930669906m },
                    { 895L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("6606db46-21cb-b09d-c34b-8b07b5cb10fb"), "Licensed Cotton Ball", 86508.6253811753064558m, 565501.761834721322986m },
                    { 896L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("938632cd-bfc5-11ef-bcaf-54b07b69a2ac"), "Generic Wooden Soap", 553741.557379052275236m, 970425.535546496201102m },
                    { 897L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("9ca8b89b-40f2-7549-5c6f-2ec34305680b"), "Unbranded Frozen Salad", 831347.512988069631158m, 874754.995064339848342m },
                    { 898L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("cc18e92a-4677-f1dc-a83d-743eca4ae8c3"), "Tasty Cotton Tuna", 723852.407859105870366m, 626715.18490411333002m },
                    { 899L, "The Football Is Good For Training And Recreational Purposes", new Guid("8c249a10-112a-01ca-2ed4-4052bcb7052c"), "Incredible Steel Towels", 314657.74112069912912m, 125416.121391050556410m },
                    { 900L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("0a511529-eef5-4b39-44bb-d2dd14a65bb2"), "Small Cotton Cheese", 949398.385832754737352m, 90115.403107524326618m },
                    { 901L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("06c74447-f711-dade-d80e-d42aa93f3dbc"), "Small Concrete Sausages", 358801.931713853365696m, 722924.869649524999688m },
                    { 902L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("bb79e590-7311-440f-4ce3-b1fe0b409726"), "Generic Frozen Chair", 498560.194104794549646m, 419835.995860686935284m },
                    { 903L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cc175516-c63e-8d8f-23ba-26dc6415b55b"), "Gorgeous Soft Chips", 162350.568846025908374m, 212317.135707828318102m },
                    { 904L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("ab4c8947-4d84-27ed-3068-fff324377375"), "Licensed Steel Soap", 909849.704269289059326m, 376515.726273369391344m },
                    { 905L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7473fcf0-d950-117b-ab8a-487f52722440"), "Gorgeous Metal Keyboard", 707342.714820881985718m, 814972.988515640074246m },
                    { 906L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("6b3c3a4b-5aeb-ddb4-b93e-4bc467c63dfa"), "Awesome Fresh Sausages", 988372.413394042718354m, 409961.130146557863084m },
                    { 907L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("2a790ecb-7cbc-56fb-82d7-1d78b8db1005"), "Awesome Granite Sausages", 764107.419255498057214m, 691613.450719036106592m },
                    { 908L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("97ee86a6-c5c8-8904-9434-d331f9a8585a"), "Ergonomic Frozen Pants", 399359.781530055501568m, 890082.815008521648576m },
                    { 909L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f07a8e03-98fd-b650-d780-f0befa21ce5d"), "Fantastic Soft Pizza", 398190.902857319522564m, 159229.383785140514910m },
                    { 910L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("dd3cfc55-245c-e969-e44b-35150ea8383e"), "Small Plastic Fish", 939808.242774674214162m, 508673.710515649273790m },
                    { 911L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a66b54a2-b794-5ec2-d8d1-5bc796445c2f"), "Incredible Metal Fish", 979678.192246179791034m, 48223.3747271288558576m },
                    { 912L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8f062da1-f3e2-2348-50af-22c83abbffe0"), "Sleek Metal Computer", 676280.796639059597284m, 350779.746809640262926m },
                    { 913L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("20d3d4a5-5cb2-89af-2dac-17d719794f12"), "Awesome Metal Pizza", 166369.705815074893696m, 633590.688369262897652m },
                    { 914L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("2cc94c86-46a6-0e87-a16f-12de1ff2108b"), "Sleek Rubber Cheese", 450543.977936958950566m, 103758.48550323396276m },
                    { 915L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("9c82dda7-1370-62eb-9901-3c795e0dd98f"), "Refined Metal Chair", 47958.1931635865436706m, 836279.176149676581252m },
                    { 916L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("d4f91547-eb2f-9ad1-bea5-0653c6977e60"), "Incredible Frozen Computer", 470196.233892956429390m, 529200.850264066668232m },
                    { 917L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("dcbb2a47-772c-54e3-678e-c9539eb9679a"), "Handcrafted Fresh Towels", 359184.512679815903444m, 640640.807139097157452m },
                    { 918L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("6bcadd91-5300-ae72-b6c5-229e15f45b89"), "Awesome Concrete Shoes", 441784.739479616902274m, 27651.7969756926452056m },
                    { 919L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("35cb4cec-6871-c5bc-ec8d-0fdb9c5a0c69"), "Licensed Steel Mouse", 202202.941009513171592m, 612048.987047471708212m },
                    { 920L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("6134391c-7dd9-2ee5-f143-7472c43376cb"), "Intelligent Cotton Shoes", 142393.828393637640272m, 680991.351596933839278m },
                    { 921L, "The Football Is Good For Training And Recreational Purposes", new Guid("60d569ed-4b03-8634-f070-0c45face9b9f"), "Practical Granite Chair", 205668.424616276096104m, 379572.055780318152104m },
                    { 922L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("49d5c69f-e1b5-1e19-00db-c78d0a738bd5"), "Practical Soft Gloves", 500731.210074883925386m, 331382.533627424216366m },
                    { 923L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("a333eadb-04e7-8614-e0b7-8c7dca624121"), "Licensed Rubber Mouse", 956059.075130984498082m, 753706.161164923843478m },
                    { 924L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("4b521904-8d1d-e706-0038-ef6d44f5c114"), "Incredible Concrete Cheese", 687057.797252540262234m, 840083.159460563743514m },
                    { 925L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("0832bdb2-0c7e-94bd-6076-ef8df231121f"), "Practical Fresh Cheese", 430004.582812331357566m, 954412.473128489089494m },
                    { 926L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4f3547d4-1af4-fb90-fcd7-c46ab30594c0"), "Sleek Granite Cheese", 269017.85510255372532m, 877623.409847607808124m },
                    { 927L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f9f989f9-afc5-9e1d-eeb1-b93a192b01cb"), "Fantastic Rubber Ball", 754838.588843898955808m, 891699.281860814478110m },
                    { 928L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("9ba73505-4be6-e754-fd79-dca717356c7b"), "Ergonomic Plastic Mouse", 45206.5450186366401850m, 496606.132889553796388m },
                    { 929L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8e361e98-5a49-c791-9f07-0e1946b192fe"), "Small Soft Sausages", 416118.092799075930148m, 144445.674139734940678m },
                    { 930L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("8ad5f85b-0856-b6af-4c7b-67289ac438bc"), "Practical Plastic Pizza", 682721.955116732877252m, 708036.688996101859376m },
                    { 931L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("924839ce-03a7-5894-d2ad-a6123904a2b2"), "Small Frozen Tuna", 17703.6196985604922586m, 706582.12571404224176m },
                    { 932L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2790660c-77e2-1efa-34fc-11958ae811c3"), "Tasty Metal Mouse", 337167.844812117705688m, 718225.077170991755962m },
                    { 933L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("27eb8789-bb00-8b6d-b5e7-6f129d5828a4"), "Awesome Plastic Car", 485322.040341553028850m, 67886.0616213448165208m },
                    { 934L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a548cbfc-588f-f36f-3d4a-ddd248d5add4"), "Ergonomic Cotton Towels", 3168.05473248888677796m, 1862.03133067893450192m },
                    { 935L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("9e5aaf1e-fc7c-b464-d85c-e50399df5c1d"), "Tasty Metal Ball", 408791.432634640565718m, 471488.902312607419404m },
                    { 936L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("27fc7205-9783-2ee4-0a7c-1e017f3269aa"), "Intelligent Rubber Pants", 673393.121734306957512m, 462219.587415602290748m },
                    { 937L, "The Football Is Good For Training And Recreational Purposes", new Guid("92b71f86-f051-89f9-ac15-d92bef3f6e46"), "Generic Cotton Car", 452014.315751005441110m, 835126.354799410893078m },
                    { 938L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("efcc71b3-4d7a-bb36-1ed3-5755b3e94f67"), "Sleek Cotton Table", 937139.271375185689046m, 957473.069889315325430m },
                    { 939L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("19355ebb-f69e-cfa0-7c89-e6947bbcd173"), "Refined Fresh Shirt", 765435.494502758250382m, 291252.092999230994836m },
                    { 940L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("41bc5252-52ba-a179-fcc5-d1965bfb3975"), "Handmade Soft Car", 78714.1823400505665398m, 210879.634726684030406m },
                    { 941L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("8b098482-2b10-d886-4367-d25d65111ebb"), "Handmade Rubber Fish", 231155.182841041699336m, 509314.080755368232866m },
                    { 942L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("6c4121b1-d1d2-66bf-311a-96cc41d182ad"), "Generic Wooden Table", 744524.285394792111318m, 996790.90845907591424m },
                    { 943L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4d37ee14-0475-2160-9660-7e20b250ca8a"), "Small Granite Keyboard", 128346.981876271862502m, 410867.085477664577042m },
                    { 944L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("44974732-3adc-f7ce-ebd8-aa0ffef7e489"), "Tasty Rubber Bike", 189265.305966968007326m, 486520.923857483201446m },
                    { 945L, "The Football Is Good For Training And Recreational Purposes", new Guid("51a68ca5-c97d-1497-dbdd-f37c37348287"), "Generic Soft Gloves", 314817.353481602768862m, 810469.843791997534146m },
                    { 946L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("2281ca35-00f3-a56e-45db-1a2d15db1045"), "Unbranded Rubber Keyboard", 276830.074761591158304m, 642297.244087420635044m },
                    { 947L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f2d0bb5b-d1bb-965c-a229-00e3da30ebd9"), "Small Concrete Chips", 174219.381898187328704m, 482496.074790999433842m },
                    { 948L, "The Football Is Good For Training And Recreational Purposes", new Guid("0c95df63-0661-267c-30b3-c0c9bca2eb0b"), "Rustic Fresh Chicken", 46924.4554950296157434m, 718780.235852354172598m },
                    { 949L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("a9342033-cae2-8b1d-9719-b3ad5e8c4c63"), "Tasty Soft Gloves", 843072.27541620687574m, 579985.499597934861492m },
                    { 950L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("0231eaed-a77a-4e22-c218-ad1adfd4b40c"), "Incredible Rubber Towels", 589433.270566045134112m, 487654.120540350302916m },
                    { 951L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("ec442da8-001c-9bd5-c590-60eec25dfb9b"), "Licensed Cotton Ball", 330401.881842039709750m, 728675.838454807385202m },
                    { 952L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("8b3f0abb-d2da-605e-43c4-e35bb29e7f24"), "Unbranded Soft Shirt", 214462.092534573084768m, 399031.183698915478242m },
                    { 953L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("f165b38b-233b-01c7-6887-f29001e3298e"), "Refined Rubber Keyboard", 78742.4886644506045142m, 323146.08488990763726m },
                    { 954L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("4f4ef673-e2f8-6ac3-3478-3d84ce348821"), "Handmade Fresh Pizza", 758712.058959033231628m, 716604.898625755327162m },
                    { 955L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("9a3662c6-3bd2-8a00-e58f-8e1b2cf2d6ea"), "Handcrafted Fresh Ball", 747904.69202641432642m, 240246.946395555223182m },
                    { 956L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("347ae69c-f997-0c20-cfc0-941e59b3a65d"), "Handmade Rubber Tuna", 264225.918379703338806m, 120086.716929153797864m },
                    { 957L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("1c41ff6f-eef1-7cda-3565-781872ff7b2f"), "Tasty Fresh Bike", 797131.806004382461634m, 705737.494261262525852m },
                    { 958L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("7df52f21-b230-3530-3066-34f4e3416bfe"), "Generic Soft Hat", 733676.579494608302596m, 866063.766169778402450m },
                    { 959L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("302af462-dbbe-f15f-47eb-b8a8b75713c5"), "Tasty Soft Bike", 813497.101889345230394m, 126307.09475212527036m },
                    { 960L, "The Football Is Good For Training And Recreational Purposes", new Guid("221efa3f-f49d-15e4-4802-4fe02eee4128"), "Gorgeous Soft Towels", 743164.403053640233162m, 57666.7637347856669124m },
                    { 961L, "The Football Is Good For Training And Recreational Purposes", new Guid("b928dae0-0022-0f5c-0a2a-7bde08f7beb9"), "Sleek Frozen Hat", 621910.04379287477310m, 801961.970253892641918m },
                    { 962L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("4ac72723-e3ba-04bd-3843-412b87bf48fc"), "Gorgeous Fresh Pizza", 999166.813084560159634m, 428160.534836926684582m },
                    { 963L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("a9269835-7ae2-a640-dc4e-6543b2cbb813"), "Handmade Rubber Bacon", 969039.35769746844388m, 814441.937456546316642m },
                    { 964L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("98f23102-d791-a6d3-b910-f2cd12a773a9"), "Fantastic Plastic Hat", 555183.791540631183130m, 69937.8486167327185806m },
                    { 965L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("1cb03096-f551-f787-9a4b-6e8e621e2c8c"), "Ergonomic Soft Hat", 173689.807252616738148m, 909245.716589363835132m },
                    { 966L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("7cca261e-904a-1bc6-b1e2-8b8fc05e4700"), "Handcrafted Granite Chair", 126401.206856515685130m, 406937.922980273288506m },
                    { 967L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("7300ae15-a83d-0e96-ccff-c42981f2666b"), "Practical Cotton Ball", 307837.079495345662528m, 936898.217214882973870m },
                    { 968L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("28aec00b-61fb-f060-4885-e1aa16efd573"), "Tasty Metal Towels", 614518.693650602623104m, 561037.3798593961312m },
                    { 969L, "The Football Is Good For Training And Recreational Purposes", new Guid("55534641-39e7-5612-65c8-f3a6b8d72df7"), "Licensed Rubber Hat", 727680.451971331333708m, 343974.889257712586266m },
                    { 970L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("f48e46ec-438c-df12-36c4-6ed8e61f1e89"), "Ergonomic Granite Soap", 870370.613216608081368m, 44142.9506374154570134m },
                    { 971L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("72db75fd-d482-5d51-7865-835ac690c8b9"), "Generic Granite Chips", 903067.341881795963816m, 284172.747550667209402m },
                    { 972L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("00c9c067-4760-13b3-75c8-8c8a0a687e90"), "Practical Plastic Hat", 664394.695405880608142m, 21435.6923288512033568m },
                    { 973L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("fa678a22-2f3f-4158-54cd-210990487d72"), "Generic Rubber Chicken", 861752.4333138863596m, 720732.474179904708528m },
                    { 974L, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("e8f4cba9-05ba-09c8-849f-19430cf24170"), "Rustic Metal Salad", 984521.465327897254468m, 627420.239320580676862m },
                    { 975L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("f1cb6a69-8f0e-ddee-6100-f769086d16fe"), "Practical Rubber Shoes", 241829.936178073326174m, 977565.670164462404574m },
                    { 976L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("802ea6bb-d7be-df1c-0016-05b379a116fd"), "Practical Cotton Pizza", 754767.934085541755142m, 665030.87123980739558m },
                    { 977L, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("a61cecdb-26c8-869f-638a-a88c61295134"), "Refined Metal Car", 626867.263066427397078m, 666300.768236334322928m },
                    { 978L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("57f29b68-1ded-1c0f-39dd-9301db0d2e14"), "Rustic Granite Computer", 102904.531123795137462m, 852093.597837043948704m },
                    { 979L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("684c540e-2da7-3e89-7c4c-e2b9976854d3"), "Licensed Metal Chicken", 903717.53972148568364m, 438698.224103272001050m },
                    { 980L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c8a3a69f-8018-aedf-ab0c-1cecd2d37c7a"), "Small Plastic Bacon", 661398.205495779414328m, 549266.989335572260504m },
                    { 981L, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("b974c4b6-0dff-df8c-52d8-2fa9b023622a"), "Ergonomic Granite Gloves", 910306.228163281445242m, 806672.395211036885892m },
                    { 982L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("d46db87a-b42f-32d5-c8d9-2ef5cb0eebd2"), "Awesome Plastic Bacon", 409794.089560235703892m, 925695.462875838463066m },
                    { 983L, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2d997e55-9d69-3ad2-15a0-095ffb0c90c0"), "Small Soft Bacon", 47126.0946374628243188m, 37750.198563844875214m },
                    { 984L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("58426b7d-2472-516c-13f2-86c56bc6abc6"), "Generic Frozen Computer", 234083.391489576689408m, 651994.125644389733502m },
                    { 985L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("f0c6068a-4188-4e20-47c2-85143ff51202"), "Ergonomic Frozen Pizza", 973613.087603704336452m, 578382.006384121703104m },
                    { 986L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("e3a90072-5b3b-cf16-9542-985c5bcbd874"), "Licensed Granite Soap", 29014.2360048627370984m, 352118.919250335024836m },
                    { 987L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0d213266-3ff8-d0de-781a-385f88aca223"), "Intelligent Cotton Fish", 55280.9198628856541070m, 373494.197706726610768m },
                    { 988L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("3e4e092e-4066-37e2-ecfc-d4c2e22df8d0"), "Awesome Granite Hat", 439399.587327102747930m, 186556.889269674235602m },
                    { 989L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("81cea3a2-3b4c-6725-045a-37b06dd0dbcf"), "Licensed Steel Gloves", 18123.5233070761956094m, 312747.441699066613598m },
                    { 990L, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("82a8a850-53e8-c885-6025-3b347daebf34"), "Intelligent Wooden Bacon", 502175.899900614495154m, 58018.6881708083871664m },
                    { 991L, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ca42cd0e-5860-5f94-a082-d65d93809fce"), "Generic Wooden Towels", 442495.341182016655062m, 437844.805059770501736m },
                    { 992L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("84047aa9-338b-33aa-252f-32905ba50ef4"), "Sleek Metal Chair", 268166.170460091416990m, 482773.335707089492616m },
                    { 993L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("73e6bdd6-0014-cc33-465c-52aa56b677dc"), "Refined Granite Chicken", 265799.384075089654158m, 494809.702817971125288m },
                    { 994L, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e6d299a4-5495-71b0-16a5-6f9d25b25819"), "Small Metal Chips", 924283.215413566036612m, 288480.21874165859750m },
                    { 995L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("6230a38e-18a3-c785-9d37-e6bdda25d0f1"), "Incredible Frozen Cheese", 689492.429682615663534m, 134750.492557514885922m },
                    { 996L, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("0a37492c-ce50-c0fe-a835-a8bd6bfa2ebf"), "Handcrafted Plastic Towels", 361561.025051976653054m, 793594.465514085591618m },
                    { 997L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7e66149e-5ff7-af69-2e7a-d9915f491375"), "Gorgeous Wooden Tuna", 619840.189835053968174m, 31149.2556392286282710m },
                    { 998L, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("f18fb095-d571-832f-deb7-ab885adab032"), "Ergonomic Metal Chips", 681383.533087402289612m, 995143.59016182909802m },
                    { 999L, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("b35d4599-ab4d-e170-2414-fdd2f3e3aa6e"), "Licensed Metal Shirt", 35248.1721231942646410m, 535827.854503419681456m },
                    { 1000L, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("214a10ab-ca15-ce5c-de30-9e90266c3b14"), "Ergonomic Soft Keyboard", 934716.190140261851238m, 601775.10520319249238m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 640L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 643L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 644L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 645L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 646L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 647L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 648L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 649L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 650L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 653L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 654L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 655L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 656L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 657L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 658L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 659L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 660L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 663L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 664L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 665L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 666L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 667L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 668L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 669L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 670L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 673L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 674L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 675L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 676L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 677L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 678L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 679L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 680L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 683L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 684L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 685L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 686L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 687L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 688L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 689L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 690L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 693L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 694L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 695L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 696L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 697L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 698L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 699L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 700L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 703L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 704L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 705L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 706L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 707L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 708L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 709L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 710L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 713L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 714L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 715L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 716L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 717L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 718L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 719L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 720L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 723L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 724L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 725L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 726L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 727L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 728L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 729L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 730L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 733L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 734L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 735L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 736L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 737L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 738L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 739L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 740L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 743L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 744L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 745L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 746L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 747L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 748L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 749L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 750L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 753L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 754L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 755L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 756L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 757L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 758L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 759L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 760L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 763L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 764L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 765L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 766L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 767L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 768L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 769L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 770L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 773L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 774L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 775L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 776L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 777L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 778L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 779L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 780L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 783L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 784L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 785L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 786L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 787L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 788L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 789L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 790L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 793L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 794L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 795L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 796L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 797L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 798L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 799L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 800L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 803L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 804L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 805L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 806L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 807L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 808L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 809L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 810L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 813L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 814L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 815L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 816L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 817L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 818L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 819L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 820L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 823L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 824L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 825L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 826L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 827L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 828L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 829L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 830L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 833L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 834L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 835L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 836L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 837L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 838L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 839L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 840L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 843L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 844L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 845L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 846L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 847L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 848L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 849L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 850L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 853L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 854L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 855L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 856L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 857L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 858L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 859L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 860L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 863L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 864L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 865L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 866L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 867L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 868L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 869L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 870L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 873L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 874L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 875L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 876L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 877L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 878L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 879L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 880L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 882L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 883L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 884L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 885L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 886L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 887L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 888L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 889L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 890L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 893L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 894L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 895L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 896L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 897L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 898L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 899L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 900L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 920L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 927L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 940L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 955L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 956L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 957L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 958L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 959L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 960L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 962L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 963L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 964L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 965L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 966L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 967L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 968L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 969L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 970L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 971L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 972L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 973L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 974L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 975L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 976L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 977L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 978L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 979L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 980L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 981L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 982L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 983L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 984L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 985L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 986L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 987L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 988L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 989L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 990L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 991L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 992L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 993L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 994L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 995L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 996L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 997L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 998L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 999L);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Sequencial",
                keyValue: 1000L);
        }
    }
}
