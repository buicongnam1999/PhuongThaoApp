<template>
    <div class="footer">
        <div class="footer-content">
            <div class="footer-content-top">
                <div class="footer-top-left">
                    <div class="footer-logo">
                        <img src="../assets/img/logo/logo.png" alt="" srcset="">
                    </div>
                    <div class="footer-address">
                        <div class="footer-address-icon">
                            <i class="fa fa-map-marker" aria-hidden="true"></i>
                        </div>
                        <div class="footer-address-text">
                            Phú Lương- Hà Đông- Hà Nội 
                        </div>
                    </div>
                    <div class="footer-phone">
                        <div class="footer-address-icon" style="padding-top: 3px">
                            <i class="fa fa-phone" aria-hidden="true"></i>
                        </div>
                        <div class="footer-address-text">
                            0387200938
                        </div>
                    </div>
                    <div class="footer-phone">
                        <div class="footer-address-icon" style="padding-top: 3px">
                            <i class="fa fa-clock-o" aria-hidden="true"></i>
                        </div>
                        <div class="footer-address-text">
                            Working time: 9.00 -21.00
                        </div>
                    </div>
                    <div class="footer-app">
                        <i class="fa fa-facebook" aria-hidden="true"></i>
                        <i class="fa fa-wifi" aria-hidden="true"></i>
                        <i class="fa fa-twitter" aria-hidden="true"></i>
                        <i class="fa fa-youtube" aria-hidden="true"></i>
                        <i class="fa fa-google-plus" aria-hidden="true"></i>
                    </div>
                </div>
                <div class="footer-top-center">
                    <div class="footer-center-content">
                        <div class="content-products">
                            <div class="content-products-title">
                                <b>Products</b>
                            </div>
                            <div class="content-products-name">
                                <div class="products-name">
                                    Prices Drop
                                </div>
                                <div class="products-name">
                                    News products
                                </div>
                                <div class="products-name">
                                    Best sale
                                </div>
                                <div class="products-name">
                                    Term & Conditions
                                </div>
                                <div class="products-name">
                                    Contact Us
                                </div>
                            </div>
                        </div>
                        <div class="content-company">
                            <div class="content-products-title">
                                <b>Our Company</b>
                            </div>
                            <div class="content-products-name">
                                <div class="products-name">
                                    Delivery
                                </div>
                                <div class="products-name">
                                    About Us
                                </div>
                                <div class="products-name">
                                    Contact Us
                                </div>
                                <div class="products-name">
                                    Sitemap
                                </div>
                                <div class="products-name">
                                    Stores
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="footer-top-right">
                    <div class="footer-right-content">
                        <div class="right-title">
                            <b>Join Our Newsletter Now</b>
                        </div>
                        <div class="right-input">
                            <div class="right-input-text">
                                <input type="text" name="" id="" placeholder="Your email address">
                            </div>
                            <div class="right-input-button">
                                <div class="button-email">
                                    <i class="fa fa-envelope-open-o" aria-hidden="true"></i>
                                </div>
                            </div>
                        </div>
                        <div class="right-text">
                            Get E-mail updates about our latest shop and special offers.
                        </div>
                    </div>
                </div>
            </div>
            <div class="footer-content-bottom">

            </div>
        </div>
    </div>
</template>

<script>
export default {
    
}
</script>

<style scoped>

/*
-----------------------FOOTER-----------------------
*/ 
.footer{
    margin-top: 100px;
    border-top: 1px solid #e5e5e5;
    width: 100%;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.footer-content{
    padding: 90px 25px;
}


/*
---------------FOOTER-TOP-------------
*/ 
.footer-content-top{
    display: flex;
    padding: 0px 25px;
}


/*
---------------Common-----------------
*/
.footer-top-left,.footer-top-center,.footer-top-right{
    width: 33%;
}
.footer-logo{
    padding-bottom: 25px;
}
.footer-logo img{
    width: 123px;
    height: 30px;
}

.footer-address, .footer-phone{
    display: flex;
}
.footer-address-icon{
    font-size: 23px;
    opacity: 0.5;
}
.footer-address-text{
    font-size: 18px;
    margin-left: 10px;
    padding-top: 7px;
    opacity: 0.9;
}

.footer-app{
    font-size: 25px;
    opacity: 0.7;
    margin-top: 30px;
}
.footer-app i{
    padding-right: 25px;
    cursor: pointer;
}
.footer-app i:hover{
    color: red;
    opacity: 1;
}
/*
-------------FOOTER-LEFT-END-----------
 */




.footer-top-center{
    opacity: 0.9;
    font-size: 19px;
}
.footer-center-content{
    display: flex;
}
.content-company, .content-products{
    width: 50%;
}
.content-products-title{
    margin-bottom: 30px;
}

.products-name{
    cursor: pointer;
    margin-bottom: 10px;
    opacity: 0.9;
}
.products-name:hover{
    color: red;
    cursor: pointer;
}

.footer-top-right{
    opacity: 0.9;
    font-size: 19px;
}

.right-input{
    display: flex;
    margin-top: 30px;
}
.right-input-text{
    height: 50px;
    width: 290PX;
    background: rgba(40, 53, 62, 0.1);
    border-radius: 3px;
}
.right-input-text input{
    outline: none;
    border: none;
    font-size: 15px;
    background: none;
    line-height: 50px;
    margin-left: 20px;
}

.button-email{
    height: 50px;
    width: 70px;
    background: rgba(255, 0, 0, 0.8);
    border-radius: 3px;
    cursor: pointer;
    margin-left: 3px;
    transition: visibility 0s, opacity 0.4s linear;
}
.button-email i{
    color: white;
    font-size: 25px;
    line-height: 50px;
    padding-left: 23px;
}
.button-email:hover{
    background: black;
    opacity: 0.8;
}
.right-text{
    opacity: 0.9;
    margin-top: 18px;
}
</style>