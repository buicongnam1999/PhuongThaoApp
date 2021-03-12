<template>
    <div class="checkbox-content">
        <input type="checkbox" name="" id=""><slot></slot>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.checkbox-content{
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
}
input[type="checkbox"]{
    height: 15px;
    width: 15px;
}
</style>