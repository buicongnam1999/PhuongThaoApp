<template>
    <div>
        <slider-view />
        <title-element :title="titles[0].title" :content="titles[0].content"/>
        <div class="product">
            <div v-for="(product,index) in products.slice(0,5)" :key="index">
                <product-element>
                    <div class="product-element-image">
                        <img src="../assets/img/products/food/1.jpg" alt="" srcset="">
                    </div>
                    <div class="product-element-search">
                        <img src="../assets/icon/search-interface-symbol.svg" alt="">
                    </div>
                </product-element>
                <div class="product-name">
                    {{product.name}}
                </div>
                <div class="product-price">
                    <div class="product-price-new">
                        <b>${{product.Price}}</b>
                    </div>
                    <div class="product-price-old">
                        <s>${{product.Priceold}}</s>
                    </div>
                </div>
                <div v-if="index === 4">
                    <br>
                </div>
            </div>
        </div>
        <div class="product">
            <div v-for="(product,index) in products.slice(5,10)" :key="index">
                <product-element>
                    <div class="product-element-image">
                        <img src="../assets/img/products/food/1.jpg" alt="" srcset="">
                    </div>
                    <div class="product-element-search">
                        <img src="../assets/icon/search-interface-symbol.svg" alt="">
                    </div>
                </product-element>
                <div class="product-name">
                    {{product.name}}
                </div>
                <div class="product-price">
                    <div class="product-price-new">
                        <b>${{product.Price}}</b>
                    </div>
                    <div class="product-price-old">
                        <s>${{product.Priceold}}</s>
                    </div>
                </div>
                <div v-if="index === 4">
                    <br>
                </div>
            </div>
        </div>
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
                    <category-slider :product_name="product_inner.product_name" :product_price="product_inner.price"/>
                </div>
                <div v-for="(product_inner,index) in product_inners_feature" :key="index" class="categori-content-element">
                    <category-slider :product_name="product_inner.product_name" :product_price="product_inner.price"/>
                </div>
                <div v-for="(product_inner,index) in product_inners_top" :key="index" class="categori-content-element">
                    <category-slider :product_name="product_inner.product_name" :product_price="product_inner.price"/>
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
import ButtonBase from '../components/base/ButtonBase.vue'
import BlogPosts from '../components/home-view/BlogPosts.vue'
import CategorySlider from '../components/home-view/CategorySlider.vue'
import ProductElement from '../components/home-view/ProductElement.vue'
import SliderView from '../components/home-view/SliderView.vue'
import SliderZoom from '../components/home-view/SliderZoom.vue'
import TitleElement from '../components/home-view/TitleElement.vue'
export default {
    components: { 
        SliderView,
        ProductElement,
        TitleElement,
        SliderZoom,
        CategorySlider,
        BlogPosts,
        ButtonBase
    },
    data() {     
        return {
            images: [
                "../../assets/img/banner/food/4-1.jpg",
                "../../assets/img/banner/food/3-5.jpg"
            ],
            count: 5,
            n: 1,
            products:[
                {
                    name: "Neque Porttitor1",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor2",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor3",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor4",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor5",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor6",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor7",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor8",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor9",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                },
                {
                    name: "Neque Porttitor10",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg",
                    sale: ''
                }
            ],
            titles:[
                {
                    title: "New Arrivals",
                    content: "Add our new arrivals to your weekly lineup"
                },
                {
                    title: "Client Testimonials",
                    content: "what they say"
                },
                {
                    title: "Latest Blog Posts",
                    content: "There are latest blog posts"
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
                "Best Sellers Products",
                "Featured Products",
                "Top Rated Products"
            ],
        }
    },
    
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
.product-name:hover{
    color: red;
}

.product-price{
    display: flex;
    margin-top: 15px;
}
.product-price-new, .product-price-old{
    font-size: 18px;
    cursor: pointer;
}
.product-price-new:hover, .product-price-old:hover{
    color: red;
}
.product-price-old{
    margin-left:10px;
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
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
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