<template>
    <div class="product-element">
        <slot></slot>
    </div>
</template>

<script>
export default {
    props:[""]
}
</script>

<style scoped>
.product-element{
    background: #e5e5ee;
    height: 264px;
    width: 218px;
}
.product-element-image img{
    height: 267px;
    width: 218px;
    position: relative;
}
.product-element-search{
    height: 50px;
    width: 50px;
    border-radius: 30px;
    background: white;
    z-index: 1;
    position: relative;
    top: -65px;
    left: 155px;
    display: none;
    cursor: pointer;
}
.product-element-search img{
    height: 20px;
    width: 20px;
    margin: 16px 15px;
    opacity: 0.3;
}

.product-element:hover .product-element-search{
    display: block;
}
</style>