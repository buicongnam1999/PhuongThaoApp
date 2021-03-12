<template>
    <div class="grid-content-element">
        <slot></slot>
        <div style="clear:both;"></div>
    </div>
</template>

<script>
export default {
    props:[""]
}
</script>

<style scoped>
.grid-content-element{
    margin: 0 27px 0 28px;
    height: 450px;
    width: 270px;
    float: left;
    font-size: 20px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
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