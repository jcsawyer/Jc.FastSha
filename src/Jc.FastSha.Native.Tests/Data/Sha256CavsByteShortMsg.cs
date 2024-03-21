﻿using Jc.FastSha.Native.Tests;

namespace Jc.FastSha.Native.Tests.Data;

internal static class Sha256CavsByteShortMsg
{
    internal static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(Utils.StringToByteArray("00"))
        {
            TestName = "0 length".PadLeft(10, '0'),
            ExpectedResult = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
        };


        yield return new TestCaseData(Utils.StringToByteArray("d3"))
        {
            TestName = "8 length".PadLeft(10, '0'),
            ExpectedResult = "28969cdfa74a12c82f3bad960b0b000aca2ac329deea5c2328ebc6f2ba9802c1",
        };


        yield return new TestCaseData(Utils.StringToByteArray("11af"))
        {
            TestName = "16 length".PadLeft(10, '0'),
            ExpectedResult = "5ca7133fa735326081558ac312c620eeca9970d1e70a4b95533d956f072d1f98",
        };


        yield return new TestCaseData(Utils.StringToByteArray("b4190e"))
        {
            TestName = "24 length".PadLeft(10, '0'),
            ExpectedResult = "dff2e73091f6c05e528896c4c831b9448653dc2ff043528f6769437bc7b975c2",
        };


        yield return new TestCaseData(Utils.StringToByteArray("74ba2521"))
        {
            TestName = "32 length".PadLeft(10, '0'),
            ExpectedResult = "b16aa56be3880d18cd41e68384cf1ec8c17680c45a02b1575dc1518923ae8b0e",
        };


        yield return new TestCaseData(Utils.StringToByteArray("c299209682"))
        {
            TestName = "40 length".PadLeft(10, '0'),
            ExpectedResult = "f0887fe961c9cd3beab957e8222494abb969b1ce4c6557976df8b0f6d20e9166",
        };


        yield return new TestCaseData(Utils.StringToByteArray("e1dc724d5621"))
        {
            TestName = "48 length".PadLeft(10, '0'),
            ExpectedResult = "eca0a060b489636225b4fa64d267dabbe44273067ac679f20820bddc6b6a90ac",
        };


        yield return new TestCaseData(Utils.StringToByteArray("06e076f5a442d5"))
        {
            TestName = "56 length".PadLeft(10, '0'),
            ExpectedResult = "3fd877e27450e6bbd5d74bb82f9870c64c66e109418baa8e6bbcff355e287926",
        };


        yield return new TestCaseData(Utils.StringToByteArray("5738c929c4f4ccb6"))
        {
            TestName = "64 length".PadLeft(10, '0'),
            ExpectedResult = "963bb88f27f512777aab6c8b1a02c70ec0ad651d428f870036e1917120fb48bf",
        };


        yield return new TestCaseData(Utils.StringToByteArray("3334c58075d3f4139e"))
        {
            TestName = "72 length".PadLeft(10, '0'),
            ExpectedResult = "078da3d77ed43bd3037a433fd0341855023793f9afd08b4b08ea1e5597ceef20",
        };


        yield return new TestCaseData(Utils.StringToByteArray("74cb9381d89f5aa73368"))
        {
            TestName = "80 length".PadLeft(10, '0'),
            ExpectedResult = "73d6fad1caaa75b43b21733561fd3958bdc555194a037c2addec19dc2d7a52bd",
        };


        yield return new TestCaseData(Utils.StringToByteArray("76ed24a0f40a41221ebfcf"))
        {
            TestName = "88 length".PadLeft(10, '0'),
            ExpectedResult = "044cef802901932e46dc46b2545e6c99c0fc323a0ed99b081bda4216857f38ac",
        };


        yield return new TestCaseData(Utils.StringToByteArray("9baf69cba317f422fe26a9a0"))
        {
            TestName = "96 length".PadLeft(10, '0'),
            ExpectedResult = "fe56287cd657e4afc50dba7a3a54c2a6324b886becdcd1fae473b769e551a09b",
        };


        yield return new TestCaseData(Utils.StringToByteArray("68511cdb2dbbf3530d7fb61cbc"))
        {
            TestName = "104 length".PadLeft(10, '0'),
            ExpectedResult = "af53430466715e99a602fc9f5945719b04dd24267e6a98471f7a7869bd3b4313",
        };


        yield return new TestCaseData(Utils.StringToByteArray("af397a8b8dd73ab702ce8e53aa9f"))
        {
            TestName = "112 length".PadLeft(10, '0'),
            ExpectedResult = "d189498a3463b18e846b8ab1b41583b0b7efc789dad8a7fb885bbf8fb5b45c5c",
        };


        yield return new TestCaseData(Utils.StringToByteArray("294af4802e5e925eb1c6cc9c724f09"))
        {
            TestName = "120 length".PadLeft(10, '0'),
            ExpectedResult = "dcbaf335360de853b9cddfdafb90fa75567d0d3d58af8db9d764113aef570125",
        };


        yield return new TestCaseData(Utils.StringToByteArray("0a27847cdc98bd6f62220b046edd762b"))
        {
            TestName = "128 length".PadLeft(10, '0'),
            ExpectedResult = "80c25ec1600587e7f28b18b1b18e3cdc89928e39cab3bc25e4d4a4c139bcedc4",
        };


        yield return new TestCaseData(Utils.StringToByteArray("1b503fb9a73b16ada3fcf1042623ae7610"))
        {
            TestName = "136 length".PadLeft(10, '0'),
            ExpectedResult = "d5c30315f72ed05fe519a1bf75ab5fd0ffec5ac1acb0daf66b6b769598594509",
        };


        yield return new TestCaseData(Utils.StringToByteArray("59eb45bbbeb054b0b97334d53580ce03f699"))
        {
            TestName = "144 length".PadLeft(10, '0'),
            ExpectedResult = "32c38c54189f2357e96bd77eb00c2b9c341ebebacc2945f97804f59a93238288",
        };


        yield return new TestCaseData(Utils.StringToByteArray("58e5a3259cb0b6d12c83f723379e35fd298b60"))
        {
            TestName = "152 length".PadLeft(10, '0'),
            ExpectedResult = "9b5b37816de8fcdf3ec10b745428708df8f391c550ea6746b2cafe019c2b6ace",
        };


        yield return new TestCaseData(Utils.StringToByteArray("c1ef39cee58e78f6fcdc12e058b7f902acd1a93b"))
        {
            TestName = "160 length".PadLeft(10, '0'),
            ExpectedResult = "6dd52b0d8b48cc8146cebd0216fbf5f6ef7eeafc0ff2ff9d1422d6345555a142",
        };


        yield return new TestCaseData(Utils.StringToByteArray("9cab7d7dcaec98cb3ac6c64dd5d4470d0b103a810c"))
        {
            TestName = "168 length".PadLeft(10, '0'),
            ExpectedResult = "44d34809fc60d1fcafa7f37b794d1d3a765dd0d23194ebbe340f013f0c39b613",
        };


        yield return new TestCaseData(Utils.StringToByteArray("ea157c02ebaf1b22de221b53f2353936d2359d1e1c97"))
        {
            TestName = "176 length".PadLeft(10, '0'),
            ExpectedResult = "9df5c16a3f580406f07d96149303d8c408869b32053b726cf3defd241e484957",
        };


        yield return new TestCaseData(Utils.StringToByteArray("da999bc1f9c7acff32828a73e672d0a492f6ee895c6867"))
        {
            TestName = "184 length".PadLeft(10, '0'),
            ExpectedResult = "672b54e43f41ee77584bdf8bf854d97b6252c918f7ea2d26bc4097ea53a88f10",
        };


        yield return new TestCaseData(Utils.StringToByteArray("47991301156d1d977c0338efbcad41004133aefbca6bcf7e"))
        {
            TestName = "192 length".PadLeft(10, '0'),
            ExpectedResult = "feeb4b2b59fec8fdb1e55194a493d8c871757b5723675e93d3ac034b380b7fc9",
        };


        yield return new TestCaseData(Utils.StringToByteArray("2e7ea84da4bc4d7cfb463e3f2c8647057afff3fbececa1d200"))
        {
            TestName = "200 length".PadLeft(10, '0'),
            ExpectedResult = "76e3acbc718836f2df8ad2d0d2d76f0cfa5fea0986be918f10bcee730df441b9",
        };


        yield return new TestCaseData(Utils.StringToByteArray("47c770eb4549b6eff6381d62e9beb464cd98d341cc1c09981a7a"))
        {
            TestName = "208 length".PadLeft(10, '0'),
            ExpectedResult = "6733809c73e53666c735b3bd3daf87ebc77c72756150a616a194108d71231272",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("ac4c26d8b43b8579d8f61c9807026e83e9b586e1159bd43b851937"))
        {
            TestName = "216 length".PadLeft(10, '0'),
            ExpectedResult = "0e6e3c143c3a5f7f38505ed6adc9b48c18edf6dedf11635f6e8f9ac73c39fe9e",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("0777fc1e1ca47304c2e265692838109e26aab9e5c4ae4e8600df4b1f"))
        {
            TestName = "224 length".PadLeft(10, '0'),
            ExpectedResult = "ffb4fc03e054f8ecbc31470fc023bedcd4a406b9dd56c71da1b660dcc4842c65",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("1a57251c431d4e6c2e06d65246a296915071a531425ecf255989422a66"))
        {
            TestName = "232 length".PadLeft(10, '0'),
            ExpectedResult = "c644612cd326b38b1c6813b1daded34448805aef317c35f548dfb4a0d74b8106",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("9b245fdad9baeb890d9c0d0eff816efb4ca138610bc7d78cb1a801ed3273"))
        {
            TestName = "240 length".PadLeft(10, '0'),
            ExpectedResult = "c0e29eeeb0d3a7707947e623cdc7d1899adc70dd7861205ea5e5813954fb7957",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("95a765809caf30ada90ad6d61c2b4b30250df0a7ce23b7753c9187f4319ce2"))
        {
            TestName = "248 length".PadLeft(10, '0'),
            ExpectedResult = "a4139b74b102cf1e2fce229a6cd84c87501f50afa4c80feacf7d8cf5ed94f042",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("09fc1accc230a205e4a208e64a8f204291f581a12756392da4b8c0cf5ef02b95"))
        {
            TestName = "256 length".PadLeft(10, '0'),
            ExpectedResult = "4f44c1c7fbebb6f9601829f3897bfd650c56fa07844be76489076356ac1886a4",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("0546f7b8682b5b95fd32385faf25854cb3f7b40cc8fa229fbd52b16934aab388a7"))
        {
            TestName = "264 length".PadLeft(10, '0'),
            ExpectedResult = "b31ad3cd02b10db282b3576c059b746fb24ca6f09fef69402dc90ece7421cbb7",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("b12db4a1025529b3b7b1e45c6dbc7baa8897a0576e66f64bf3f8236113a6276ee77d"))
        {
            TestName = "272 length".PadLeft(10, '0'),
            ExpectedResult = "1c38bf6bbfd32292d67d1d651fd9d5b623b6ec1e854406223f51d0df46968712",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("e68cb6d8c1866c0a71e7313f83dc11a5809cf5cfbeed1a587ce9c2c92e022abc1644bb"))
        {
            TestName = "280 length".PadLeft(10, '0'),
            ExpectedResult = "c2684c0dbb85c232b6da4fb5147dd0624429ec7e657991edd95eda37a587269e",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("4e3d8ac36d61d9e51480831155b253b37969fe7ef49db3b39926f3a00b69a36774366000"))
        {
            TestName = "288 length".PadLeft(10, '0'),
            ExpectedResult = "bf9d5e5b5393053f055b380baed7e792ae85ad37c0ada5fd4519542ccc461cf3",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("03b264be51e4b941864f9b70b4c958f5355aac294b4b87cb037f11f85f07eb57b3f0b89550"))
        {
            TestName = "296 length".PadLeft(10, '0'),
            ExpectedResult = "d1f8bd684001ac5a4b67bbf79f87de524d2da99ac014dec3e4187728f4557471",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("d0fefd96787c65ffa7f910d6d0ada63d64d5c4679960e7f06aeb8c70dfef954f8e39efdb629b"))
        {
            TestName = "304 length".PadLeft(10, '0'),
            ExpectedResult = "49ba38db85c2796f85ffd57dd5ec337007414528ae33935b102d16a6b91ba6c1",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray("b7c79d7e5f1eeccdfedf0e7bf43e730d447e607d8d1489823d09e11201a0b1258039e7bd4875b1"))
        {
            TestName = "312 length".PadLeft(10, '0'),
            ExpectedResult = "725e6f8d888ebaf908b7692259ab8839c3248edd22ca115bb13e025808654700",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray(
                "64cd363ecce05fdfda2486d011a3db95b5206a19d3054046819dd0d36783955d7e5bf8ba18bf738a"))
        {
            TestName = "320 length".PadLeft(10, '0'),
            ExpectedResult = "32caef024f84e97c30b4a7b9d04b678b3d8a6eb2259dff5b7f7c011f090845f8",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray(
                "6ac6c63d618eaf00d91c5e2807e83c093912b8e202f78e139703498a79c6067f54497c6127a23910a6"))
        {
            TestName = "328 length".PadLeft(10, '0'),
            ExpectedResult = "4bb33e7c6916e08a9b3ed6bcef790aaaee0dcf2e7a01afb056182dea2dad7d63",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray(
                "d26826db9baeaa892691b68900b96163208e806a1da077429e454fa011840951a031327e605ab82ecce2"))
        {
            TestName = "336 length".PadLeft(10, '0'),
            ExpectedResult = "3ac7ac6bed82fdc8cd15b746f0ee7489158192c238f371c1883c9fe90b3e2831",
        };


        yield return new TestCaseData(
            Utils.StringToByteArray(
                "3f7a059b65d6cb0249204aac10b9f1a4ac9e5868adebbe935a9eb5b9019e1c938bfc4e5c5378997a3947f2"))
        {
            TestName = "344 length".PadLeft(10, '0'),
            ExpectedResult = "bfce809534eefe871273964d32f091fe756c71a7f512ef5f2300bcd57f699e74",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "60ffcb23d6b88e485b920af81d1083f6291d06ac8ca3a965b85914bc2add40544a027fca936bbde8f359051c"))
        {
            TestName = "352 length".PadLeft(10, '0'),
            ExpectedResult = "1d26f3e04f89b4eaa9dbed9231bb051eef2e8311ad26fe53d0bf0b821eaf7567",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "9ecd07b684bb9e0e6692e320cec4510ca79fcdb3a2212c26d90df65db33e692d073cc174840db797504e482eef"))
        {
            TestName = "360 length".PadLeft(10, '0'),
            ExpectedResult = "0ffeb644a49e787ccc6970fe29705a4f4c2bfcfe7d19741c158333ff6982cc9c",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "9d64de7161895884e7fa3d6e9eb996e7ebe511b01fe19cd4a6b3322e80aaf52bf6447ed1854e71001f4d54f8931d"))
        {
            TestName = "368 length".PadLeft(10, '0'),
            ExpectedResult = "d048ee1524014adf9a56e60a388277de194c694cc787fc5a1b554ea9f07abfdf",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "c4ad3c5e78d917ecb0cbbcd1c481fc2aaf232f7e289779f40e504cc309662ee96fecbd20647ef00e46199fbc482f46"))
        {
            TestName = "376 length".PadLeft(10, '0'),
            ExpectedResult = "50dbf40066f8d270484ee2ef6632282dfa300a85a8530eceeb0e04275e1c1efd",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "4eef5107459bddf8f24fc7656fd4896da8711db50400c0164847f692b886ce8d7f4d67395090b3534efd7b0d298da34b"))
        {
            TestName = "384 length".PadLeft(10, '0'),
            ExpectedResult = "7c5d14ed83dab875ac25ce7feed6ef837d58e79dc601fb3c1fca48d4464e8b83",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "047d2758e7c2c9623f9bdb93b6597c5e84a0cd34e610014bcb25b49ed05c7e356e98c7a672c3dddcaeb84317ef614d342f"))
        {
            TestName = "392 length".PadLeft(10, '0'),
            ExpectedResult = "7d53eccd03da37bf58c1962a8f0f708a5c5c447f6a7e9e26137c169d5bdd82e4",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "3d83df37172c81afd0de115139fbf4390c22e098c5af4c5ab4852406510bc0e6cf741769f44430c5270fdae0cb849d71cbab"))
        {
            TestName = "400 length".PadLeft(10, '0'),
            ExpectedResult = "99dc772e91ea02d9e421d552d61901016b9fd4ad2df4a8212c1ec5ba13893ab2",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "33fd9bc17e2b271fa04c6b93c0bdeae98654a7682d31d9b4dab7e6f32cd58f2f148a68fbe7a88c5ab1d88edccddeb30ab21e5e"))
        {
            TestName = "408 length".PadLeft(10, '0'),
            ExpectedResult = "cefdae1a3d75e792e8698d5e71f177cc761314e9ad5df9602c6e60ae65c4c267",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "77a879cfa11d7fcac7a8282cc38a43dcf37643cc909837213bd6fd95d956b219a1406cbe73c52cd56c600e55b75bc37ea69641bc"))
        {
            TestName = "416 length".PadLeft(10, '0'),
            ExpectedResult = "c99d64fa4dadd4bc8a389531c68b4590c6df0b9099c4d583bc00889fb7b98008",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "45a3e6b86527f20b4537f5af96cfc5ad8777a2dde6cf7511886c5590ece24fc61b226739d207dabfe32ba6efd9ff4cd5db1bd5ead3"))
        {
            TestName = "424 length".PadLeft(10, '0'),
            ExpectedResult = "4d12a849047c6acd4b2eee6be35fa9051b02d21d50d419543008c1d82c427072",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "25362a4b9d74bde6128c4fdc672305900947bc3ada9d9d316ebcf1667ad4363189937251f149c72e064a48608d940b7574b17fefc0df"))
        {
            TestName = "432 length".PadLeft(10, '0'),
            ExpectedResult = "f8e4ccab6c979229f6066cc0cb0cfa81bb21447c16c68773be7e558e9f9d798d",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "3ebfb06db8c38d5ba037f1363e118550aad94606e26835a01af05078533cc25f2f39573c04b632f62f68c294ab31f2a3e2a1a0d8c2be51"))
        {
            TestName = "440 length".PadLeft(10, '0'),
            ExpectedResult = "6595a2ef537a69ba8583dfbf7f5bec0ab1f93ce4c8ee1916eff44a93af5749c4",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "2d52447d1244d2ebc28650e7b05654bad35b3a68eedc7f8515306b496d75f3e73385dd1b002625024b81a02f2fd6dffb6e6d561cb7d0bd7a"))
        {
            TestName = "448 length".PadLeft(10, '0'),
            ExpectedResult = "cfb88d6faf2de3a69d36195acec2e255e2af2b7d933997f348e09f6ce5758360",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "4cace422e4a015a75492b3b3bbfbdf3758eaff4fe504b46a26c90dacc119fa9050f603d2b58b398cad6d6d9fa922a154d9e0bc4389968274b0"))
        {
            TestName = "456 length".PadLeft(10, '0'),
            ExpectedResult = "4d54b2d284a6794581224e08f675541c8feab6eefa3ac1cfe5da4e03e62f72e4",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "8620b86fbcaace4ff3c2921b8466ddd7bacae07eefef693cf17762dcabb89a84010fc9a0fb76ce1c26593ad637a61253f224d1b14a05addccabe"))
        {
            TestName = "464 length".PadLeft(10, '0'),
            ExpectedResult = "dba490256c9720c54c612a5bd1ef573cd51dc12b3e7bd8c6db2eabe0aacb846b",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "d1be3f13febafefc14414d9fb7f693db16dc1ae270c5b647d80da8583587c1ad8cb8cb01824324411ca5ace3ca22e179a4ff4986f3f21190f3d7f3"))
        {
            TestName = "472 length".PadLeft(10, '0'),
            ExpectedResult = "02804978eba6e1de65afdbc6a6091ed6b1ecee51e8bff40646a251de6678b7ef",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "f499cc3f6e3cf7c312ffdfba61b1260c37129c1afb391047193367b7b2edeb579253e51d62ba6d911e7b818ccae1553f6146ea780f78e2219f629309"))
        {
            TestName = "480 length".PadLeft(10, '0'),
            ExpectedResult = "0b66c8b4fefebc8dc7da0bbedc1114f228aa63c37d5c30e91ab500f3eadfcec5",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "6dd6efd6f6caa63b729aa8186e308bc1bda06307c05a2c0ae5a3684e6e460811748690dc2b58775967cfcc645fd82064b1279fdca771803db9dca0ff53"))
        {
            TestName = "488 length".PadLeft(10, '0'),
            ExpectedResult = "c464a7bf6d180de4f744bb2fe5dc27a3f681334ffd54a9814650e60260a478e3",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "6511a2242ddb273178e19a82c57c85cb05a6887ff2014cf1a31cb9ba5df1695aadb25c22b3c5ed51c10d047d256b8e3442842ae4e6c525f8d7a5a944af2a"))
        {
            TestName = "496 length".PadLeft(10, '0'),
            ExpectedResult = "d6859c0b5a0b66376a24f56b2ab104286ed0078634ba19112ace0d6d60a9c1ae",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "e2f76e97606a872e317439f1a03fcd92e632e5bd4e7cbc4e97f1afc19a16fde92d77cbe546416b51640cddb92af996534dfd81edb17c4424cf1ac4d75aceeb"))
        {
            TestName = "504 length".PadLeft(10, '0'),
            ExpectedResult = "18041bd4665083001fba8c5411d2d748e8abbfdcdfd9218cb02b68a78e7d4c23",
        };


        yield return new TestCaseData(Utils.StringToByteArray(
            "5a86b737eaea8ee976a0a24da63e7ed7eefad18a101c1211e2b3650c5187c2a8a650547208251f6d4237e661c7bf4c77f335390394c37fa1a9f9be836ac28509"))
        {
            TestName = "512 length".PadLeft(10, '0'),
            ExpectedResult = "42e61e174fbb3897d6dd6cef3dd2802fe67b331953b06114a65c772859dfc1aa",
        };
    }
}