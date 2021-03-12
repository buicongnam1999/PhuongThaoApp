<template>
    <div>
        <slider-view />
        <title-element :title="titles[1].title" :content="titles[1].content"/>
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
        <title-element :title="titles[2].title" :content="titles[2].content"/>
    </div> 
</template>
<script>
import ProductElement from '../components/home-view/ProductElement.vue'
import SliderView from '../components/home-view/SliderView.vue'
import TitleElement from '../components/home-view/TitleElement.vue'
export default {
    components: { 
        SliderView,
        ProductElement,
        TitleElement
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
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor2",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor3",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor4",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor5",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor6",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor7",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor8",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor9",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
                },
                {
                    name: "Neque Porttitor10",
                    Price: 3000,
                    Priceold: 5000,
                    img: "../../assets/img/banner/food/4-1.jpg"
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
                }

            ]
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
    margin: 20px 60px;
}