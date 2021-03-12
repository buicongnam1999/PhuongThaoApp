<template>
    <div class="categorie-slider">
        <div class="feature-inner-pro">
            <div class="categori-slider-active">
                <div class="pro-inner-image">
                    <img src="../../assets/img/products/food/12.jpg" alt="">
                </div>
                <div class="pro-inner-info">
                    <div class="pro-inner-name">
                        {{product_name}}
                    </div>
                    <div class="pro-inner-price">
                        {{product_price}}
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
    product_price: String
    }
}
</script>
<style scoped>
.categorie-slider{
    width: 100%;
}
.categori-slider-active{
    display: flex;
}

.pro-inner-image img{
    width: 92px;
    height: 110px;
}
</style>