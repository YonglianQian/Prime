<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication0430.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script type="text/javascript">
        $(function () {
            var a = {
                "carriers": [
                    {
                        "carrier_id": "se-123890",
                        "carrier_code": "stamps_com",
                        "account_number": null,
                        "requires_funded_amount": true,
                        "balance": 0.0,
                        "nickname": "Free",
                        "friendly_name": "Stamps.com",
                        "primary": true,
                        "has_multi_package_supporting_services": false,
                        "services": [
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_first_class_mail",
                                "name": "USPS First Class Mail",
                                "domestic": true,
                                "international": false,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_media_mail",
                                "name": "USPS Media Mail",
                                "domestic": true,
                                "international": false,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_parcel_select",
                                "name": "USPS Parcel Select Ground",
                                "domestic": true,
                                "international": false,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_priority_mail",
                                "name": "USPS Priority Mail",
                                "domestic": true,
                                "international": false,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_priority_mail_express",
                                "name": "USPS Priority Mail Express",
                                "domestic": true,
                                "international": false,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_first_class_mail_international",
                                "name": "USPS First Class Mail Intl",
                                "domestic": false,
                                "international": true,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_priority_mail_international",
                                "name": "USPS Priority Mail Intl",
                                "domestic": false,
                                "international": true,
                                "is_multi_package_supported": false
                            },
                            {
                                "carrier_id": "se-123890",
                                "carrier_code": "stamps_com",
                                "service_code": "usps_priority_mail_express_international",
                                "name": "USPS Priority Mail Express Intl",
                                "domestic": false,
                                "international": true,
                                "is_multi_package_supported": false
                            }
                        ],
                        "packages": [
                            {
                                "package_id": null,
                                "package_code": "cubic",
                                "name": "Cubic",
                                "description": "Cubic"
                            },
                            {
                                "package_id": null,
                                "package_code": "flat_rate_envelope",
                                "name": "Flat Rate Envelope",
                                "description": "USPS flat rate envelope. A special cardboard envelope provided by the USPS that clearly indicates \"Flat Rate\"."
                            },
                            {
                                "package_id": null,
                                "package_code": "flat_rate_legal_envelope",
                                "name": "Flat Rate Legal Envelope",
                                "description": "Flat Rate Legal Envelope"
                            },
                            {
                                "package_id": null,
                                "package_code": "flat_rate_padded_envelope",
                                "name": "Flat Rate Padded Envelope",
                                "description": "Flat Rate Padded Envelope"
                            },
                            {
                                "package_id": null,
                                "package_code": "large_envelope_or_flat",
                                "name": "Large Envelope or Flat",
                                "description": "Large envelope or flat. Has one dimension that is between 11 1/2\" and 15\" long, 6 1/18\" and 12\" high, or 1/4\" and 3/4\" thick."
                            },
                            {
                                "package_id": null,
                                "package_code": "large_flat_rate_box",
                                "name": "Large Flat Rate Box",
                                "description": "Large Flat Rate Box"
                            },
                            {
                                "package_id": null,
                                "package_code": "large_package",
                                "name": "Large Package (any side > 12\")",
                                "description": "Large package. Longest side plus the distance around the thickest part is over 84\" and less than or equal to 108\"."
                            },
                            {
                                "package_id": null,
                                "package_code": "letter",
                                "name": "Letter",
                                "description": "Letter"
                            },
                            {
                                "package_id": null,
                                "package_code": "medium_flat_rate_box",
                                "name": "Medium Flat Rate Box",
                                "description": "USPS flat rate box. A special 11\" x 8 1/2\" x 5 1/2\" or 14\" x 3.5\" x 12\" USPS box that clearly indicates \"Flat Rate Box\""
                            },
                            {
                                "package_id": null,
                                "package_code": "package",
                                "name": "Package",
                                "description": "Package. Longest side plus the distance around the thickest part is less than or equal to 84\""
                            },
                            {
                                "package_id": null,
                                "package_code": "regional_rate_box_a",
                                "name": "Regional Rate Box A",
                                "description": "Regional Rate Box A"
                            },
                            {
                                "package_id": null,
                                "package_code": "regional_rate_box_b",
                                "name": "Regional Rate Box B",
                                "description": "Regional Rate Box B"
                            },
                            {
                                "package_id": null,
                                "package_code": "small_flat_rate_box",
                                "name": "Small Flat Rate Box",
                                "description": "Small Flat Rate Box"
                            },
                            {
                                "package_id": null,
                                "package_code": "thick_envelope",
                                "name": "Thick Envelope",
                                "description": "Thick envelope. Envelopes or flats greater than 3/4\" at the thickest point."
                            }
                        ],
                        "options": []
                    }
                ]
            };
            $("#div1").append(a.carriers[0].carrier_id + " " + a.carriers[0].carrier_code + "<br>");
            $.each(a.carriers[0].services, function (i, n) {
               
                console.log(n.carrier_id);
                console.log(n.carrier_code);
                $("#div2").append(n.carrier_id + " " + n.carrier_code+"<br>");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1" style="border:1px solid #808080">
        </div>
        <div id="div2" style="border:5px solid #00ff21">
        </div>
    </form>
</body>
</html>
