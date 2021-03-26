<template>
    <div class="categorie-slider">
        <div class="feature-inner-pro">
            <div class="categori-slider-active">
                <div class="pro-inner-image">
                    <img :src="require(`../../assets/img/products/food/${img}`)" alt="">
                </div>
                <div class="pro-inner-info">
                    <div class="pro-inner-name">
                        {{product_name}}
                    </div>
                    <div class="pro-inner-price">
                        {{product_price}} VNĐ
                    </div>
                </div>
            </div>
        </div>
        <br>
    </div>
</template>
<script>
export default {
    props:{
    product_name: String,
    product_price: String,
    img: String
    },
    data() {
        return {
        }
    },
    methods: {
        
    },
}
</script>
<style scoped>
.categorie-slider{
    width: 100%;
    -webkit-overflow-scrolling: touch;
  scroll-behavior: smooth;
}
.categori-slider-active{
    display: flex;
}

.pro-inner-image img{
    width: 92px;
    height: 110px;
}
.pro-inner-info{
    margin-left: 10px;
}
.pro-inner-name,.pro-inner-price{
    cursor: pointer;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
.pro-inner-name:active{
    color: red;
    opacity: 0.8;
}
.pro-inner-price{
    margin-top: 10px;
}
</style>