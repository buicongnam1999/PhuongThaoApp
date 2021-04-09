<template>
    <div>
        <slider-view />
        <title-element :title="titles[0].title" :content="titles[0].content"/>
        <div class="product">
            <div v-for="(product_inner,index) in product_inners_best.slice(0,5)" :key="index">
                <div @click="ShowDetailProduct(product_inner.food_description,product_inner.food_img,product_inner.food_id,product_inner.food_name,product_inner.food_money)">
                    <product-element :img="product_inner.food_img"/>
                </div>
                <div class="product-name">
                    {{product_inner.food_name}}
                </div>
                <div class="product-price">
                    <div class="product-price-new">
                        <b>{{product_inner.food_money}} VNĐ</b>
                        <div v-if="product_inner.food_quality === 0">
                            <div class="button">
                                <button-base >Hết hàng</button-base>
                            </div>
                        </div>
                        <div v-else>
                            <div class="button" @click="Addtocart(product_inner.food_id)">
                                <button-base ><i class="fa fa-plus" aria-hidden="true"></i>Thêm vào giỏ</button-base>
                            </div>
                        </div>
                    </div>
                    <div class="product-price-old">
                        <s>{{product_inner.food_money * product_inner.cou_number}}</s>
                    </div>
                </div>
            </div>
        </div>
        <div class="product" style="margin-top:50px;">
            <div v-for="(product_inner,index) in product_inners_best.slice(5,10)" :key="index">
                <div @click="ShowDetailProduct(product_inner.food_description,product_inner.food_img,product_inner.food_id,product_inner.food_name,product_inner.food_money)">
                    <product-element :img="product_inner.food_img"/>
                </div>
                <div class="product-name">
                    {{product_inner.food_name}}
                </div>
                <div class="product-price">
                    <div class="product-price-new">
                        <b>{{product_inner.food_money}} VNĐ</b>
                        <div v-if="product_inner.food_quality === 0">
                            <div class="button">
                                <button-base >Hết hàng</button-base>
                            </div>
                        </div>
                        <div v-else>
                            <div class="button" @click="Addtocart(product_inner.food_id)">
                                <button-base><i class="fa fa-plus" aria-hidden="true"></i>Thêm vào giỏ</button-base>
                            </div>
                        </div>
                    </div>
                    <div class="product-price-old">
                        <s>{{product_inner.food_money * product_inner.cou_number}}</s>
                    </div>
                </div>
            </div>
        </div>
        <product-dialog :image="image" :note="note" :price="price" :name="name" :isHide="isHide" :id="id" @CloseDialog="CloseDialog"/>
        <pop-up-basic :isHide="isHidePop">
            <div slot="title">
                Thông báo
            </div>
            <div slot="message">
                Bạn có muốn thêm vào giỏ hàng?
            </div>
            <div slot="button">
                <div class="button-pop">
                    <div class="btn-sucess" @click="Ok">Đồng ý</div>
                    <div class="btn-cancel" @click="Cancel">Hủy bỏ</div>
                </div>
            </div>
        </pop-up-basic>
        <title-element :title="titles[1].title" :content="titles[1].content"/>
        <slider-zoom />
        <div class="category">
            <div v-for="(title_inner,index) in title_inners" :key="index" >
                <div class="pro-inner-title">
                    <b>{{title_inner}}</b>
                    <div class="border-inner-title"></div>
                    <div class="pro-button-back">
                        <i class="fa fa-angle-left" aria-hidden="true"></i>
                    </div>
                    <div class="pro-button-next">
                        <i class="fa fa-angle-right" aria-hidden="true"></i>
                    </div>
                </div>
            </div>
        </div>
        <div class="categori-content">
            <div class="categori-content-center">
                <div v-for="(product_inner,index) in product_inners_best" :key="index" class="categori-content-element">
                    <category-slider :product_name="product_inner.food_name" :product_price="product_inner.food_money" :img="product_inner.food_img"/>
                </div>
            </div>
        </div>
        <div style="clear: both;"></div>
        <title-element :title="titles[2].title" :content="titles[2].content"/>
        <div class="blog">
            <blog-posts>
                <img src="../assets/img/blog/blg30.jpg" alt="" srcset="">
                <div class="blog-title">
                    Best Mackup Secret
                </div>
                <div class="blog-info">
                    <div class="blog-info-date">
                        <i class="fa fa-calendar" aria-hidden="true"></i>
                        Dec 14, 2019
                    </div>
                    <div class="blog-info-user">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        By Makali
                    </div>
                </div>
                <div class="blog-content">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                    Ipsum has
                    been the industrys standard dummy text ever since ...
                </div>
                <button-base>Read more</button-base>
            </blog-posts>
            <blog-posts>
                <img src="../assets/img/blog/blg28.jpg" alt="" srcset="">
                <div class="blog-title">
                    Best Mackup Secret
                </div>
                <div class="blog-info">
                    <div class="blog-info-date">
                        <i class="fa fa-calendar" aria-hidden="true"></i>
                        Dec 14, 2019
                    </div>
                    <div class="blog-info-user">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        By Makali
                    </div>
                </div>
                <div class="blog-content">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                    Ipsum has
                    been the industrys standard dummy text ever since ...
                </div>
                <button-base>Read more</button-base>
            </blog-posts>
            <blog-posts>
                <img src="../assets/img/blog/blg31.jpg" alt="" srcset="">
                <div class="blog-title">
                    Best Mackup Secret
                </div>
                <div class="blog-info">
                    <div class="blog-info-date">
                        <i class="fa fa-calendar" aria-hidden="true"></i>
                        Dec 14, 2019
                    </div>
                    <div class="blog-info-user">
                        <i class="fa fa-user" aria-hidden="true"></i>
                        By Makali
                    </div>
                </div>
                <div class="blog-content">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                    Ipsum has
                    been the industrys standard dummy text ever since ...
                </div>
                <button-base>Read more</button-base>
            </blog-posts>
        </div>
        <div class="brand">
            <img src="../assets/img/brand/b1.jpg" alt="" srcset="">
            <img src="../assets/img/brand/b2.jpg" alt="" srcset="">
            <img src="../assets/img/brand/b3.jpg" alt="" srcset="">
            <img src="../assets/img/brand/b4.jpg" alt="" srcset="">
            <img src="../assets/img/brand/b5.jpg" alt="" srcset="">
        </div>
    </div>
</template>

<script>
import axios from "axios";
import ButtonBase from '../components/base/ButtonBase.vue'
import BlogPosts from '../components/home-view/BlogPosts.vue'
import CategorySlider from '../components/home-view/CategorySlider.vue'
import ProductElement from '../components/home-view/ProductElement.vue'
import SliderView from '../components/home-view/SliderView.vue'
import SliderZoom from '../components/home-view/SliderZoom.vue'
import TitleElement from '../components/home-view/TitleElement.vue'
import PopUpBasic from '../components/base/PopUpBasic.vue';
import ProductDialog from '../components/home-view/ProductDialog.vue';
import swal from 'sweetalert';
export default {
    components: { 
        SliderView,
        ProductElement,
        TitleElement,
        SliderZoom,
        CategorySlider,
        BlogPosts,
        ButtonBase,
        PopUpBasic,
        ProductDialog,
    },
    data() {  
        return {
            images: [
                "../../assets/img/banner/food/4-1.jpg",
                "../../assets/img/banner/food/3-5.jpg"
            ],
            count: 5,
            n: 1,
            products:[],
            foods:[],
            titles:[
                {
                    title: "Sản phẩm mới",
                    content: "Các sản phẩm luôn được thêm mới"
                },
                {
                    title: "Sản phẩm được chú ý",
                    content: "Các sản phẩm được nhiều người thích nhât"
                },
                {
                    title: "Các bài viết yêu thích nhân",
                    content: "Các bài báo mới nhất"
                }
            ],
            product_inners_best: [
                {
                    product_name: "Commodo Dolor",
                    price: "78" 
                },
                {
                    product_name: "Duis Bibendum",
                    price: "50" 
                },
                {
                    product_name: "Odio Tortor Consequat",
                    price: "30" 
                }
            ],
            product_inners_feature: [
                {
                    product_name: "Commodo Dolor",
                    price: "78" 
                },
                {
                    product_name: "Duis Bibendum",
                    price: "50" 
                },
                {
                    product_name: "Odio Tortor Consequat",
                    price: "30" 
                }
            ],
            product_inners_top: [
                {
                    product_name: "Commodo Dolor",
                    price: "78" 
                },
                {
                    product_name: "Duis Bibendum",
                    price: "50" 
                },
                {
                    product_name: "Odio Tortor Consequat",
                    price: "30" 
                }
            ],
            title_inners:[
                "Sản phẩm tốt",
                "Sản phẩm ưa chuộng",
                "Top sản phẩm"
            ],
            image: '',
            isHide: true,
            price: 0,
            name: '',
            note: '',
            isHidePop: true,
            id: 0,
            console:{
                "error": null,
                "sucess": false,
                "data": {
                    "devMessage": null,
                    "userMessage": ""
                }
            }
        }
    },
    methods:{
        // Bật thông báo xác nhận
        Addtocart(id){
            this.isHidePop = !this.isHidePop
            // Lấy giá trị ID của sản phẩm
            this.id = id
        },
        // Xác nhận thêm vào giỏ hàng
        async Ok(){
            // Gửi xác thực lên serve
            await axios.post("https://localhost:44344/api/cart/1&&"+this.id)
            .then(res => this.console = res.data)
            if(this.console.sucess){
                // Đưa ra thông báo nếu thành công
                swal("Thêm thành công", "Cảm ơn bạn đã thêm vào giỏ hàng!","success");
            }
            // Trả về giá trị ID ban đầu
            this.id = 0
            // Đóng thông báo
            this.isHidePop = !this.isHidePop
        },
        // Hủy xác nhận thêm vào giỏ hàng
        Cancel: function(){
            this.isHidePop = !this.isHidePop
        },
        // Hiển thị chi form chi tiết sản phẩm
        ShowDetail: function(){
            // Mở form chi tiết sản phẩm
            this.isHide = true
            alert(this.id)
        },
        // Gán giá trị cho form chi tiết sản phẩm đó
        ShowDetailProduct(note,img,id,name,money){
            this.image = img,
            this.note = note
            this.id = id,
            this.name = name,
            this.price = money,
            this.isHide = !this.isHide
        },
        // Đóng form chi tiết sản phẩm
        CloseDialog: function(){
            this.isHide = !this.isHide
        }
    },

    // Khởi tạo ban đầu để lấy giá trị
    async created(){
        // Khởi tạo giá trị ban đầu
        await axios.get("https://localhost:44344/api/food")
        .then(res => this.product_inners_best = res.data)
        await axios.get("https://localhost:44344/api/food")
        .then(res => this.foods = res.data)

        //Format tiền
        this.product_inners_best.forEach(element => {
            var money = element.food_money;
            if (money) {
                money =  money.toFixed(0).replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1.");
            } else {
                money = 0;  
            }
            element.food_money = money;
        })
    }
    
}
</script>
<style scoped>
/*
--------------PRODUCT--------------
*/
.product{
    display: flex;
    justify-content: space-between;
    width: 90%;
    margin: 20px 64px;
}

/*
 */
.product-element-image:hover{
    
}
/*

 */
.product-name{
    font-size: 18px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    opacity: 0.8;
    margin-top: 20px;
    cursor: pointer;
}
.button{
    z-index: 5;
    position: relative;
    top: -2px;
    display: none;
}
.product-content:hover .button-base{
    display: inline;
    width: 60%;
}
.product-content:hover .product-price-new{
    display: none;
}
.product-name:hover{
    color: red;
}

.product-price{
    display: flex;
    margin-top: 15px;
}
.product-price-new{
    width: 60%;
}
.product-price-new, .product-price-old{
    font-size: 18px;
    cursor: pointer;
}
.product-price-new:hover, .product-price-old:hover{
    color: red;
}
.product-price-new:hover b{
    display: none;
}
.product-price-new:hover .button{
    display: block;
}
.product-price-old{
    margin-left:10px;
    opacity: 0.8;
    justify-content: flex-end;
    width: 40%;
}


/*

 */
 .category{
     display: flex;
     width: 89%;
     margin: 0 auto;
     justify-content: space-between;
     margin-top: 100px;
 }
 .pro-inner-title{
    font-size: 25px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    display: flex;
    margin-top: 5px;
}

.border-inner-title{
    border-top: 1px dashed ;
    z-index: -1;
    width: 90px;
    margin: 21px 10px;
    opacity: 0.4;
}

.pro-button-back,.pro-button-next{
    font-size: 20px;
    margin-right: 10px;
    line-height: 38px;
}

.categori-content{
    margin: 30px auto;
    width: 100%;
}
.categori-content-center{
    width: 90%;
    margin: 0px auto;
    height: 30px;
}
.categori-content-element{
    width: 33.33%;
    float: right;
}

.blog{
    display: flex;
    width: 90%;
    margin: 0px auto;
    justify-content: space-between;
}
.blog-title{
    margin-top: 20px;
    font-size: 20px;
    cursor: pointer;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.blog-title:hover{
    color: red;
    opacity: 0.8;
}
.blog-info{
    display: flex;
}
.blog-info-date,.blog-info-user{
    cursor: pointer;
    width: 50%;
    margin-top: 10px;
    font-size: 18px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.blog-info-user:hover{
    color: red;
    opacity: 0.9;
}
.blog-content{
    margin-bottom: 20px;
    margin-top: 10px;
    font-size: 20px;
    font-family: 'Times New Roman', Times, serif;
}
.brand{
    border-top: 1px solid #e5e5e5;
    padding-top: 80px;
    margin: 100px 0px 0px 63px;
    width: 90%;
    display: flex;
    justify-content: space-between;
}
</style>